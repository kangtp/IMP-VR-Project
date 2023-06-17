using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HingeJointListener : MonoBehaviour  //Script to run the function when the lever is pulled
{
    [SerializeField]
    private float angleThreshold = 10;

    [SerializeField]
    private HingeJointState hingeJointState = HingeJointState.None;

    [SerializeField]
    private UnityEvent OnActivate;

    [SerializeField]
    private UnityEvent OnNone;
    private enum HingeJointState { Activate, None }

    [SerializeField]
    private HingeJoint joint;


    // Update is called once per frame
    void FixedUpdate()
    {
        float distanceToMin = Mathf.Abs(joint.angle - joint.limits.min);

        if (distanceToMin < angleThreshold)
        {
            if (hingeJointState != HingeJointState.Activate)
            {
                OnActivate.Invoke();
            }
            hingeJointState = HingeJointState.Activate;
        }
        else
        {
            if (hingeJointState != HingeJointState.None)
            {
                OnNone.Invoke();
                hingeJointState = HingeJointState.None;
            }
        }
    }
}

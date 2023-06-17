using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    public GameObject original; //original customer prefab

    //EatMode prefab has mouse, and there is collider. 
    private void OnTriggerEnter(Collider other)
    {
        //If you put the skewer to the customer's mouth
        if (other.CompareTag("Stick"))
        {
            //Run Skewer Comparison Function
            original.GetComponent<EatModeScript>().CheckSkewer();
        }
    }
}

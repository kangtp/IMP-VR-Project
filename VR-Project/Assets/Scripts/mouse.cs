using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    public GameObject original;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Stick"))
        {
            original.GetComponent<EatModeScript>().CheckSkewer();
        }
    }
}

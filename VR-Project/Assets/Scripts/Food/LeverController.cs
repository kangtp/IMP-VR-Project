using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool activate = false;
    public GameObject spawnPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Activate()
    {
        if (spawnPoint != null)
        {
            if (spawnPoint.GetComponent<Throwing>().myCorutine == null)
            {
                spawnPoint.GetComponent<Throwing>().myCorutine = StartCoroutine(spawnPoint.GetComponent<Throwing>().MakeFood(spawnPoint.GetComponent<Throwing>().madeFoodArray));
            }
            else
            {
                StopCoroutine(spawnPoint.GetComponent<Throwing>().myCorutine);
                spawnPoint.GetComponent<Throwing>().myCorutine = null;
            }
        }
    }

}

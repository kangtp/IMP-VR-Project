using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool activate = false;//Lever state
    public GameObject spawnPoint; // spawn point1
    public GameObject spawnPoint2;// spawn point2
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Activate()
    {
        if (spawnPoint != null) // spawin point is not null
        {
            if (spawnPoint.GetComponent<Throwing>().myCorutine == null)// Now, spawnpoint is not active
            {
                spawnPoint.GetComponent<Throwing>().myCorutine = StartCoroutine(spawnPoint.GetComponent<Throwing>().MakeFood(spawnPoint.GetComponent<Throwing>().madeFoodArray));//make spawnpoint active
                spawnPoint2.GetComponent<Throwing2>().myCorutine = StartCoroutine(spawnPoint2.GetComponent<Throwing2>().MakeFood(spawnPoint2.GetComponent<Throwing2>().madeFoodArray));//make spawnpoint2 active

            }
            else
            {
                StopCoroutine(spawnPoint.GetComponent<Throwing>().myCorutine); // Now,spawnpoin active
                spawnPoint.GetComponent<Throwing>().myCorutine = null; // maek stop
                StopCoroutine(spawnPoint2.GetComponent<Throwing2>().myCorutine);
                spawnPoint2.GetComponent<Throwing2>().myCorutine = null;//make stop
            }
        }
    }

}
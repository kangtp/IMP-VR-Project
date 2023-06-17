using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update

    //this script is about end Game manager

    public GameObject[] simsaweeOne; // get 3 Customer gameObject

    public Text Result; // get Result Text
    private int count = 0; // when customer happy add this value!!
    private int finishCount = 0; // when customer didn't eat food and then add this value
    private int angrystack = 0; // when customer angry add this value;
    bool AAAAAA; // this is a value of control Ring a bell;
    void Start()
    {
        AAAAAA = true; // first set AAAAAA true. because it is has to be Call One Time!!!
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Stick")) // if hit bell by stick
        {
            finishCount = 0; // set 0
            count = 0; // set 0
            for (int i = 0; i < 3; i++) // number of customer's are 3 so loop 3time~
            {
               int a = simsaweeOne[i].GetComponent<Animator>().GetInteger("Condition"); // get animation of information beacause it is very simple that easier to another way
               if(a == 1) // if customer happy
               {
                 count++; // add count
               }
               if(a == 2) // if customer angry
               {
                 angrystack++; // add angrystack
               }
               if(a == 3) // if customer didn't eat food
               {
                   finishCount++; // add finishCount;
               }
            }

            if(finishCount > 0) // if finishCount is more than 0. Change Text like that below.
            {
                Result.text = "There's a customer who hasn't received the food yet!";
                
            }
            else if(finishCount == 0 && AAAAAA) // if all customer ate food Call goTomenu();
            {
                AAAAAA = false; // change condition
                Result.text = "You are " + count + "Star Cheif~"; // change Text
                StartCoroutine("goTomenu"); // call coroutine
            }
        }
    }

    IEnumerator goTomenu() // go to Menu Function
    {
        yield return new WaitForSeconds(4.0f); // after 4 seconds
        SceneManager.LoadScene("MainMEnu"); // LoadScene (MainMEnu)
    }
}

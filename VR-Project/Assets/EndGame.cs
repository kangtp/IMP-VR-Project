using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] simsaweeOne;

    public Text Result;
    private int count = 0;
    private int finishCount = 0;
    private int angrystack = 0;
    bool AAAAAA;
    void Start()
    {
        AAAAAA = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Stick"))
        {
            finishCount = 0;
            count = 0;
            for (int i = 0; i < 3; i++)
            {
               int a = simsaweeOne[i].GetComponent<Animator>().GetInteger("Condition");
               if(a == 1)
               {
                 count++;
               }
               if(a == 2)
               {
                 angrystack++;
               }
               if(a == 3)
               {
                   finishCount++;
                   Debug.Log(finishCount);
               }
            }

            if(finishCount > 0)
            {
                Result.text = "There's a customer who hasn't received the food yet!";
                
            }
            else if(finishCount == 0 && AAAAAA)
            {
                AAAAAA = false;
                Result.text = "You are " + count + "Star Cheif~";
                StartCoroutine("goTomenu");
            }
        }
    }

    IEnumerator goTomenu()
    {
        yield return new WaitForSeconds(4.0f);
        SceneManager.LoadScene("MainMEnu");
    }
}

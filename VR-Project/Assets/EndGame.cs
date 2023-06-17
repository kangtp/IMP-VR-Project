using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] simsaweeOne;
    public Image[] result;
    private int count = 0;
    private int finishCount = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Stick"))
        {
            for(int i = 0; i < 3; i++)
            {
               int a = simsaweeOne[i].GetComponent<Animator>().GetInteger("Condition");
               if(a == 1)
               {
                 count++;
               }
               else if(a == 3)
               {
                finishCount++;
               }
            }


            result[0].enabled = false;
            result[1].enabled = true;

            if(finishCount < 2)
            {
                result[1].GetComponentInChildren<Text>().text = "There's a customer who hasn't received the food yet!";
                finishCount = 0;
                count = 0;
            }
            else
            {
                result[1].GetComponentInChildren<Text>().text = "You are " + count + "Star Cheif~";
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

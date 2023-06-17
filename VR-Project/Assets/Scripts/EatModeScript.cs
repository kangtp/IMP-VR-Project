using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatModeScript : MonoBehaviour
{
    public GameObject eatMode;
    public AudioSource audioSource;
    public AudioClip goodEat;   
    public AudioClip badEat;
    public string[] skewer; //skewer that customer want
    private string[] mySkewer;  //skewer that I made
    public GameObject trashFunction;    
    private bool feed = false; 

    //If you touch customer with skewer, customer change into EatMode
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Stick") && !feed)
        {
            gameObject.SetActive(false);    //this original prefab set false
            eatMode.SetActive(true);    //eatMode prefab set true
            feed = true;    //to feed once
        }
    }

    //to compare skewer I made with skewer customer want
    public void CheckSkewer()
    {
        eatMode.SetActive(false);
        gameObject.SetActive(true);

        //Get the information of the skewers I made. (ingredient order)
        mySkewer = FindObjectOfType<RecognizeFood>().GetSkewerFoods();  

        for (int i = 0; i < mySkewer.Length; i++)
        {
            //Play angry animation if one is different
            if (mySkewer[i] != skewer[i])
            {
                audioSource.clip = badEat;  //angry reaction
                audioSource.Play();
                gameObject.GetComponent<Animator>().SetInteger("Condition", 2);    //angry animation
                trashFunction.GetComponent<TrashBin>().Reset(); //skewer reset
                return;
            }
        }

        //Play happy animation if it's all the same
        audioSource.clip = goodEat; //happy reaction
        audioSource.Play();
        gameObject.GetComponent<Animator>().SetInteger("Condition", 1);    //happy animation
        trashFunction.GetComponent<TrashBin>().Reset(); //skewer reset
        return;
    }
}

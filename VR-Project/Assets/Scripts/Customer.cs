using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Customer : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator CustomerAnimator;
    private NavMeshAgent navMeshAgent;

    public Transform goalPosition;

    private Image Food_image;

    private int condition;

    void Start()
    {
        CustomerAnimator = GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        Food_image = GetComponentInChildren<Image>();
        //Food_image.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        /*
        if(Input.GetKeyDown("w"))
        {
            //CustomerAnimator.SetInteger("Condition",0);
            //navMeshAgent.SetDestination(goalPosition.position);

        }
        else if(Input.GetKeyDown("a"))
        {
            CustomerAnimator.SetInteger("Condition",1); //happy
        }
        else if(Input.GetKeyDown("s"))
        {
            CustomerAnimator.SetInteger("Condition",2); //angry
        }
        else if(Input.GetKeyDown("d"))
        {
            CustomerAnimator.SetInteger("Condition",3);
        }
        */
        

    }

    public void Happy()
    {
        CustomerAnimator.SetInteger("Condition", 1);
        Debug.Log("Happy dance");
    }

    public void Angry()
    {
        CustomerAnimator.SetInteger("Condition", 2);
    }

}

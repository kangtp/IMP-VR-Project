using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Customer : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator CustomerAnimator; // 
    private NavMeshAgent navMeshAgent; // this is a naveMeshAgent to use AI funtion.
    private Image Food_image;
    private int condition; // To change Animation Condition.

   
    public GameObject PlayerPosition; // to get player Position

    void Start()
    {
        CustomerAnimator = GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        Food_image = GetComponentInChildren<Image>();

        GetComponent<Animator>().SetInteger("Condition",3); // 3 is a Idle condition
        //Food_image.enabled = false;
    }

    public void Happy() // set Condition Happy
    {
        CustomerAnimator.SetInteger("Condition", 1); // 1 is a Happy Condition
    }

    public void Angry() // set condition Angry
    {
        CustomerAnimator.SetInteger("Condition", 2); // 2 is a Angry Condition
    }

}

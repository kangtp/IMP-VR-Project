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
        Food_image.enabled = false;
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
            CustomerAnimator.SetInteger("Condition",1);
        }
        else if(Input.GetKeyDown("s"))
        {
            CustomerAnimator.SetInteger("Condition",2);
        }
        else if(Input.GetKeyDown("d"))
        {
            CustomerAnimator.SetInteger("Condition",3);
        }
        */
        

    }

    private void OnTriggerEnter(Collider other) {
        if(other.transform.tag == "Goal")
        {
            StartCoroutine("DetailStop");
        }
    }

    IEnumerator DetailStop()
    {
        yield return new WaitForSeconds(0.75f);
        CustomerAnimator.SetInteger("Condition",3);
    }

    IEnumerator NPC_Behavior()
    {
         yield return new WaitForSeconds(0.75f);
    }
}

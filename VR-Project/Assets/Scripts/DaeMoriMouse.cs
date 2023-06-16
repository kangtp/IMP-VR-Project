using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaeMoriMouse : MonoBehaviour
{
    public GameObject daeMori;
    public AudioSource eatSound;

    private void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("food"))
        {
            eatSound.Play();
            daeMori.GetComponent<Animator>().SetInteger("Condition", 1);
            Debug.Log("daeMori eat");
        }
    }
}

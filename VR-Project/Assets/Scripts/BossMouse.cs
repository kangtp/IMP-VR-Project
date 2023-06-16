using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMouse : MonoBehaviour
{
    public GameObject boss;
    public AudioSource eatSound;

    private void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("food"))
        {
            eatSound.Play();
            boss.GetComponent<Animator>().SetInteger("Condition", 1);
            Debug.Log("boss eat");
        }

    }
}

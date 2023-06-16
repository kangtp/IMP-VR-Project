using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    public GameObject bigboy;
    public AudioSource eatSound;

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("food"))
        {
            eatSound.Play();
            bigboy.GetComponent<Animator>().SetInteger("Condition", 1);
            Debug.Log("bigboy eat");
        }

    }
}

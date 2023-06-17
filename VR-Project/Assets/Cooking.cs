using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooking : MonoBehaviour
{
    // this script is about cooking skrewe
    private ParticleSystem smoke;

    void Start()
    {
        smoke = GetComponentInChildren<ParticleSystem>(); // getcomponent of Particlesystem
    }

    public void CookSmoke()
    {
        smoke.Play();  // play particle system
    }

    public void Stopcook()
    {
        smoke.Stop(); //stop particle system
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooking : MonoBehaviour
{

    private ParticleSystem smoke;

    void Start()
    {
        smoke = GetComponentInChildren<ParticleSystem>();
    }

    private void Update() {

        
    }

    public void CookSmoke()
    {
        smoke.Play();   
    }

    public void Stopcook()
    {
        smoke.Stop();
    }
   
}

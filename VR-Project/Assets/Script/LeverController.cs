using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour
{
    // Start is called before the first frame update
    bool foodFire = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LeverPull()
    {
        foodFire = !foodFire;
    }
    public bool GetFoodThrowState()
    {
        return foodFire;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TrashBin : MonoBehaviour
{
    public GameObject fork;

    public void Reset()
    {
        bool[] _checkFood = { true, false, false, false };
        fork.GetComponent<RecognizeFood>().checkFood = _checkFood;
        string[] _skewerfoods = { "Null", "Null", "Null", "Null" };
        fork.GetComponent<RecognizeFood>().skewerfoods = _skewerfoods;
        for (int i=0;i<4;i++)
        {
            
           for(int j=0;j<8;j++)
           {
             fork.transform.GetChild(i).GetChild(j).gameObject.SetActive(false);
           }
                
           
        }
        
    }

}

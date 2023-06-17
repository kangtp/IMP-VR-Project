using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TrashBin : MonoBehaviour
{
    public GameObject fork;

    public void Reset()
    {
        bool[] _checkFood = { true, false, false, false }; // To return the skewer recognizable status to its initial state
        fork.GetComponent<RecognizeFood>().checkFood = _checkFood;//Revert to initial state
        string[] _skewerfoods = { "Null", "Null", "Null", "Null" };//To return the skewer recognizable status to its initial state
        fork.GetComponent<RecognizeFood>().skewerfoods = _skewerfoods;//Revert to initial state
        for (int i=0;i<4;i++)
        {
            
           for(int j=0;j<8;j++) //Each child is set false, that is, the skewer becomes empty.
            {
             fork.transform.GetChild(i).GetChild(j).gameObject.SetActive(false);
           }
                
           
        }
        
    }

}

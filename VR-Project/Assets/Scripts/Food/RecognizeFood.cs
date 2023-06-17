using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class RecognizeFood : MonoBehaviour
{
    // Start is called before the first frame update
    public bool[] checkFood = { true, false, false, false }; //Food point in fork recognize state
    public GameObject[] childs;// it is fork point gameobject array
    public string[] skewerfoods = { "Null", "Null", "Null", "Null" }; //recognize food array
    private AudioSource _audioSource;//audiosource to play


    void Start()
    {
        _audioSource = GetComponent<AudioSource>();//Get audioComponent
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {


        
        Destroy(other.gameObject.GetComponent<MeshCollider>()); // destroy other meshcollider
        for (int i = 0; i < checkFood.Length; i++)
        {
            bool foodRecoginze = false;//food recognize state
            if (checkFood[i] == true)
            {
                 
                for (int j = 0; j < 8; j++)//to access ForkPoint(foods in fork)
                {

                    if (other.tag == childs[i].transform.GetChild(j).tag)//if other tag == foodpint child tag
                    {

                        
                        childs[i].transform.GetChild(j).gameObject.SetActive(true);//child of foodpoint set true then foodpoint[i].[j] is active
                        _audioSource.Play();//when succes play sound 
                        skewerfoods[i] = other.tag;// because other object need recognize food so made array
                        if (i == 3)// because in order to be recognized
                        {
                            checkFood[3] = false;// because To avoid over-array errors
                        }
                        else
                        {
                            checkFood[i] = false; // In order not to be recognized
                            checkFood[i + 1] = true;
                        }
                        foodRecoginze = true;//The food that is now flying has been recognized
                        Destroy(other.gameObject);//destroy flying food 
                        Debug.Log(childs[i].transform.GetChild(j).gameObject.tag + "����");//just test

                        break;
                    }
                }
            }
            if (foodRecoginze)//to avoid the repetition
            {
                break;
            }

        }


    }
    public string[] GetSkewerFoods()
    {
        return skewerfoods;//return recognize fork foods array
    }



}
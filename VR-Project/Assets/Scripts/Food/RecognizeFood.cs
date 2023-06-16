using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class RecognizeFood : MonoBehaviour
{
    // Start is called before the first frame update
    bool[] checkFood = { true, false, false, false }; //처음엔 5개 모두 비활성화 상태
    public GameObject[] childs;
    private string[] skewerfoods = { "Null", "Null", "Null", "Null" };


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {


        Debug.Log("Food 인식");
        Destroy(other.gameObject.GetComponent<MeshCollider>());
        for (int i = 0; i < checkFood.Length; i++)
        {
            bool foodRecoginze = false;
            if (checkFood[i] == true)
            {
                Debug.Log("푸드포인트  i 인식" + i);
                for (int j = 0; j < 7; j++)
                {

                    if (other.tag == childs[i].transform.GetChild(j).tag)
                    {

                       
                        childs[i].transform.GetChild(j).gameObject.SetActive(true);
                        skewerfoods[i] = other.tag;
                        if (i == 3)
                        {
                            checkFood[3] = false;
                        }
                        else
                        {
                            checkFood[i] = false;
                            checkFood[i + 1] = true;
                        }
                        foodRecoginze = true;
                        Destroy(other.gameObject);
                        Debug.Log(childs[i].transform.GetChild(j).gameObject.tag + "꽃힘");

                        break;
                    }
                }
            }
            if (foodRecoginze)
            {
                break;
            }

        }


    }
    public string[] GetSkewerFoods()
    {
        return skewerfoods;
    }



}
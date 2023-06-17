using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class RecognizeFood : MonoBehaviour
{
    // Start is called before the first frame update
    public bool[] checkFood = { true, false, false, false }; //ó���� 5�� ��� ��Ȱ��ȭ ����
    public GameObject[] childs;
    public string[] skewerfoods = { "Null", "Null", "Null", "Null" };


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {


        Debug.Log("Food �ν�");
        Destroy(other.gameObject.GetComponent<MeshCollider>());
        for (int i = 0; i < checkFood.Length; i++)
        {
            bool foodRecoginze = false;
            if (checkFood[i] == true)
            {
                Debug.Log("Ǫ������Ʈ  i �ν�" + i);
                for (int j = 0; j < 8; j++)
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
                        Debug.Log(childs[i].transform.GetChild(j).gameObject.tag + "����");

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
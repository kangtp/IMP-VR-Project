using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaeMoriMouse : MonoBehaviour
{
    public GameObject daeMori;
    public AudioSource audioSource;
    public AudioClip goodEat;
    public AudioClip badEat;
    private string[] damoriSkewer = { "Leg", "Salmon", "Salmon", "Chop" };
    private string[] makeSkewer;

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Stick"))
        {
            makeSkewer = FindObjectOfType<RecognizeFood>().GetSkewerFoods();
            if (CheckSkewer(makeSkewer) == true)
            {
                audioSource.clip = goodEat;
                audioSource.Play();
                daeMori.GetComponent<Animator>().SetInteger("Condition", 1);    //happy
                Debug.Log("�� ���ƿ�");
            }
            else
            {
                audioSource.clip = badEat;
                audioSource.Play();
                daeMori.GetComponent<Animator>().SetInteger("Condition", 2);    //angry
                Debug.Log("�̰� �ƴ��ݾ�");
            }
            
        }
    }

    bool CheckSkewer(string[] mySkewer)
    {
        for(int i = 0; i < makeSkewer.Length; i++)
        {
            if (mySkewer[i] != damoriSkewer[i])
            {
                return false;
            }
        }
        return true;
    }
}

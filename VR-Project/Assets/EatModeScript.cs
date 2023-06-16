using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatModeScript : MonoBehaviour
{
    public GameObject eatMode;
    public AudioSource audioSource;
    public AudioClip goodEat;
    public AudioClip badEat;
    public string[] skewer;
    private string[] mySkewer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Stick"))
        {
            gameObject.SetActive(false);
            eatMode.SetActive(true);
            Debug.Log("Collider");

        }
    }
    public void CheckSkewer()
    {
        eatMode.SetActive(false);
        gameObject.SetActive(true);
        mySkewer = FindObjectOfType<RecognizeFood>().GetSkewerFoods();
        for (int i = 0; i < mySkewer.Length; i++)
        {
            if (mySkewer[i] != skewer[i]) //��ġ�� �ֹ��� �Ŷ� �ٸ���
            {
                audioSource.clip = badEat;
                audioSource.Play();
                gameObject.GetComponent<Animator>().SetInteger("Condition", 2);    //angry
                Debug.Log("�̰� �ƴ��ݾ�");
                return;
            }
        }
        //�ֹ��� �Ŷ� ������
        audioSource.clip = goodEat;
        audioSource.Play();
        gameObject.GetComponent<Animator>().SetInteger("Condition", 1);    //happy
        Debug.Log("�� ���ƿ�");
        return;
    }
}

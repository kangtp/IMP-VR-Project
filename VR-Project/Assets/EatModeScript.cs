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
    public GameObject trashFunction;
    private bool feed = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Stick") && !feed)
        {
            gameObject.SetActive(false);
            eatMode.SetActive(true);
            Debug.Log("Collider");
            feed = true;
        }
    }
    public void CheckSkewer()
    {
        eatMode.SetActive(false);
        gameObject.SetActive(true);
        mySkewer = FindObjectOfType<RecognizeFood>().GetSkewerFoods();
        for (int i = 0; i < mySkewer.Length; i++)
        {
            if (mySkewer[i] != skewer[i]) //꼬치가 주문한 거랑 다르면
            {
                audioSource.clip = badEat;
                audioSource.Play();
                gameObject.GetComponent<Animator>().SetInteger("Condition", 2);    //angry
                Debug.Log("이거 아니잖아");
                trashFunction.GetComponent<TrashBin>().Reset();
                return;
            }
        }
        //주문한 거랑 같으면
        audioSource.clip = goodEat;
        audioSource.Play();
        gameObject.GetComponent<Animator>().SetInteger("Condition", 1);    //happy
        Debug.Log("음 좋아요");
        trashFunction.GetComponent<TrashBin>().Reset();
        return;
    }
}

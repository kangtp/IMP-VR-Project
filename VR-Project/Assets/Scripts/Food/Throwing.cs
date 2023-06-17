using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>
    ///  1.makingFoodArray => 여러종류의 음식이 각각 5번씩 발사되기 위한 배열을 만들고 섞어주는 함수!
    ///  2.MakingFood => 배열을 받고 그 배열의 인덱스를 각각 읽어서 맞는 번호에 따른 음식 생성을 하는 함수!
    ///   ++ 발사도 함. 
    ///  그리고 lever의 foodFireState(bool형)에 따라 발사되거나 발사가 멈춤 아마 내 생각엔 레버를 당기기 전까진 계속 무한으로 발사할거임
    ///
    /// </summary>
    public GameObject[] foodsPrefeb;
    public float speed;
    
    
    bool clear_lever = false;
    public Coroutine myCorutine;
    public int[] madeFoodArray;
    void Start()
    {
        
        madeFoodArray = MakingFoodArray();
    }
    void Update()
    {

    }
    private void FixedUpdate()
    {

    }
    public static List<string> foods = new List<string>() {
        "PepperGreen","LambChop","LambLeg","Peach","SalamiA","SalamiSlice","Salmon","Tomato"
    };

    public int[] MakingFoodArray()
    {

        int[] result = new int[40]; // 40 크기의 1차원 배열 생성
        int[] cnt = new int[8]; // 각 음식이 몇 번씩 들어갔는지 세는 배열
        int foodIndex; // 랜덤한 음식의 인덱스



        List<string> foodList = new List<string>();
        foreach (string food in foods)
        {
            for (int i = 0; i < 5; i++)
            {
                foodList.Add(food);
            }
        }


        for (int i = 0; i < 40; i++)
        {
            int j = Random.Range(i, 40);
            string tmp = foodList[i];
            foodList[i] = foodList[j];
            foodList[j] = tmp;
        }


        for (int i = 0; i < 40; i++)
        {
            foodIndex = foods.IndexOf(foodList[i]); // 음식 인덱스 가져옴
            result[i] = foodIndex; // 해당 인덱스로 배열에 저장
            cnt[foodIndex]++; // 음식 카운트 증가
        }

        return result; // 완성된 배열 리턴
    }
    public IEnumerator MakeFood(int[] foodArray)
    {
        while (true)
        {
            for (int i = 0; i < foodArray.Length; i++)
            {
                if (foodArray[i] == 0)
                {
                    GameObject pepper = Instantiate(foodsPrefeb[0], gameObject.transform.position, Quaternion.identity);
                    ThrowingFood(pepper);




                }
                else if (foodArray[i] == 1)
                {
                    GameObject lambChop = Instantiate(foodsPrefeb[1], gameObject.transform.position, Quaternion.identity);
                    ThrowingFood(lambChop);


                }
                else if (foodArray[i] == 2)
                {
                    GameObject lambLeg = Instantiate(foodsPrefeb[2], gameObject.transform.position, Quaternion.identity);
                    ThrowingFood(lambLeg);

                }
                else if (foodArray[i] == 3)
                {
                    GameObject peach = Instantiate(foodsPrefeb[3], gameObject.transform.position, Quaternion.identity);
                    ThrowingFood(peach);

                }
                else if (foodArray[i] == 4)
                {
                    GameObject salamiA = Instantiate(foodsPrefeb[4], gameObject.transform.position, Quaternion.identity);
                    ThrowingFood(salamiA);

                }
                else if (foodArray[i] == 5)
                {
                    GameObject salamiSlice = Instantiate(foodsPrefeb[5], gameObject.transform.position, Quaternion.identity);
                    ThrowingFood(salamiSlice);

                }
                else if (foodArray[i] == 6)
                {
                    GameObject Salmon = Instantiate(foodsPrefeb[6], gameObject.transform.position, Quaternion.identity);
                    ThrowingFood(Salmon);

                }
                else if (foodArray[i] == 7)
                {
                    GameObject Tomato = Instantiate(foodsPrefeb[7], gameObject.transform.position, Quaternion.identity);
                    ThrowingFood(Tomato);


                }
                yield return new WaitForSeconds(3f);

            }
        }
    }
    public void ThrowingFood(GameObject food)
    {
        Vector3 dir = gameObject.transform.forward;
       
        food.GetComponent<Rigidbody>().velocity = dir * speed;
        Destroy(food, 7f);

    }



}
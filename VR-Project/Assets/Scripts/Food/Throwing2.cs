using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing2 : MonoBehaviour
{
    // Start is called before the first frame update
    /// 
    /// To have two identical points in a different arrangement than the "throw" script
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

        int[] result = new int[40]; 
        int[] cnt = new int[8]; 
        int foodIndex; 



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
            foodIndex = foods.IndexOf(foodList[i]); 
            result[i] = foodIndex; 
            cnt[foodIndex]++; 
        }

        return result; 
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>
    ///  
    ///
    /// </summary>
    public GameObject[] foodsPrefeb; // flying food prefebs
    public float speed;//flying speed
    
    
   
    public Coroutine myCorutine;//it is need because when lever is pull then fire food
    public int[] madeFoodArray;//it is the arrangement required to fire food
    void Start()
    {
        
        madeFoodArray = MakingFoodArray();//make flying foods array
    }
    void Update()
    {

    }
    private void FixedUpdate()
    {

    }
    public static List<string> foods = new List<string>() { // it is food name list
        "PepperGreen","LambChop","LambLeg","Peach","SalamiA","SalamiSlice","Salmon","Tomato"
    };

    public int[] MakingFoodArray()
    {

        int[] result = new int[40]; //an arrangement containing the order in which food is fired
        int[] cnt = new int[8]; // an arrangement that counts how many times each food is in it
        int foodIndex; //food index



        List<string> foodList = new List<string>();// an arrangement containing food names
        foreach (string food in foods)//For function to allow 5 pieces of each dish to go in
        {
            for (int i = 0; i < 5; i++)
            {
                foodList.Add(food);
            }
        }


        for (int i = 0; i < 40; i++)// The part to mix the arrangements
        {
            int j = Random.Range(i, 40);
            string tmp = foodList[i];
            foodList[i] = foodList[j];
            foodList[j] = tmp;
        }


        for (int i = 0; i < 40; i++)
        {
            foodIndex = foods.IndexOf(foodList[i]); // Importing index
            result[i] = foodIndex; // Save array to that index
            cnt[foodIndex]++; // count increase
        }

        return result; //return result
    }
    public IEnumerator MakeFood(int[] foodArray) //it instantiate food and fire
    {
        while (true) // Unlimited fire until the lever is pulled
        {
            for (int i = 0; i < foodArray.Length; i++)//food array(foodprefeb index) ,Create the right game object based on the number
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
                yield return new WaitForSeconds(3f);// Launch in 3 seconds after launch

            }
        }
    }
    public void ThrowingFood(GameObject food)// Code for flying food
    {
        Vector3 dir = gameObject.transform.forward;
       
        food.GetComponent<Rigidbody>().velocity = dir * speed;
        Destroy(food, 7f);

    }



}
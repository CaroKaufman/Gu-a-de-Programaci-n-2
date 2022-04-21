using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Realizar un programa que muestre los números entre dos enteros ingresados por el usuario. Chequear que no sean iguales.

public class While_02 : MonoBehaviour
{
    public int num1, num2;
   
    
    
    // Start is called before the first frame update
    void Start()
    {
        if(num1 < num2)
        {
            while (num1<num2)
            {
                Debug.Log(num1);
                num1++;
                
            }
        }
        else 
        {
            while (num1 > num2)
            {
                Debug.Log(num2);
                num2++;
                
            }
        }

         Debug.Log("Los números son iguales");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

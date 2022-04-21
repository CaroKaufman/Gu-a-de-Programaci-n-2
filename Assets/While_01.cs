using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While_01 : MonoBehaviour
{
    int counter = 1;
    int counterMax = 5;
    // Start is called before the first frame update
    void Start()
    {
        while (counter<=counterMax)
        {
            Debug.Log("este mensaje c repetira, esta es la counter " + counter + " vuelta");
            counter++;
        }
        Debug.Log("Termino el while");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

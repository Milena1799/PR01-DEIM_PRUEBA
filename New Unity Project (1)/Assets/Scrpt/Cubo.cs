using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour 
{
    public int num1 = 7;
    public int num2 = 3;
    private int result;


    // Start is called before the first frame update
    void Start()
    {
        result = num1 + num2;
        if(result  <10)
        {
            Debug.Log("El resultado es igual a 10");
        }
        else if(result >10)
        {
            Debug.Log("El resultado es menor a 10");
        }
        else
        {
            Debug.Log("El resultado es igual a 10");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    public int num1 = 15;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 <= 25)
        {
            num1++;

        }
        else
        {
            print("Ha llegado al limite");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

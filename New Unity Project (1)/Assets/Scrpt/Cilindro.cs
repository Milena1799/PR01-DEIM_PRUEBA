using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cilindro : MonoBehaviour
{
    float aleatorio; 
    // Start is called before the first frame update
    void Start()
    {
        for(int n =0; n < 10; n++)
        {
            aleatorio = Random.Range(0, 5);
            print(aleatorio);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

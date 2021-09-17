using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboDos : MonoBehaviour
{
    public int myNum;
    // Start is called before the first frame update
    void Start()
    {
        for (myNum = 5; myNum < 0; myNum++)
        {
            Debug.Log (myNum);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

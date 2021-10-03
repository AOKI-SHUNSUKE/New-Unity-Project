using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter8_3 : MonoBehaviour
{
    int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }
    // Start is called before the first frame update
    void Start()
    {
        int num = Add(3, 6);
        Debug.Log(num);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

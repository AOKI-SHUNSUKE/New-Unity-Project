using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter8_2 : MonoBehaviour
{
    void HelloName(string name)
    {
        Debug.Log("Hello, " + name);
    }
    // Start is called before the first frame update
    void Start()
    {
        HelloName("Unity");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

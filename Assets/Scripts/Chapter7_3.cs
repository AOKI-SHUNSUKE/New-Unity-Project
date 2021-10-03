using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter7_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] points = new int[5];
        points[0] = 30;
        points[1] = 20;
        points[2] = 50;
        points[3] = 10;
        points[4] = 80;
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

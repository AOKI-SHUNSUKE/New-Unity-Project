
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kadai_lesson4 : MonoBehaviour
{
    int[] numbers = new int[]{1,2,3,4,5};
    // Start is called before the first frame update
    void Start()
    {
        for (int number = 0; number < numbers.Length; number++) Debug.Log("plus->"+numbers[number]);

        for (int M = numbers.Length-1; M >= 0; M--)Debug.Log("minus" + numbers[M]);
       


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

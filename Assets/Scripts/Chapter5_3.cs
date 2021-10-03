using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int money = 100;
        if(money <= 50)
        {
            Debug.Log("Sell weapon");
        }else if(money >= 200)
        {
            Debug.Log("Buy weapon");
        }
        else
        {
            Debug.Log("Buy potion");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

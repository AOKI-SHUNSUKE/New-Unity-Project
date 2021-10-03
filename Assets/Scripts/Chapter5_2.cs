using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int money = 50;
        if (money >= 100)
        {
            Debug.Log("buy potion");
        }
        else
        {
            Debug.Log("Sell Weapon");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

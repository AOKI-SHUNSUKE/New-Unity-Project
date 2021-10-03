using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
     private int hp = 100;
    private int power = 25;

    public void Attack()
    {
        Debug.Log(this.power + "Damage!!");
    }
    public void Defence(int damage)
    {
        Debug.Log(damage + "Damaged!!");
        this.hp -= damage;
    }
}

public class Chapter9_3 : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        Boss lastboss = new Boss();
        lastboss.Attack();
        lastboss.Defence(3);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}

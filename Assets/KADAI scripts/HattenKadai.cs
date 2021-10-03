using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBoss
{
    private int mp = 53;

    public void MagicAttack()
    {
       if(mp >= 5)
        {
            
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔術が使えない。");
        }
    }


}

public class HattenKadai : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        MagicBoss BlackMajician = new MagicBoss();
        for ( int i=0; i <11; i++)
        {
            BlackMajician.MagicAttack();
           
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

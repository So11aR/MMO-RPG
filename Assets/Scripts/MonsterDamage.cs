using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDamage : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag.Contains("Enemy") && other.GetComponent<Health>())
        {
           // if(isOnAttack == true)
           // {
                other.GetComponent<Health>().GetDamage(40);
           // }
          //  isOnAttack = true;
            
        }
    }
}

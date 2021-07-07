using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDamage : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag.Contains("Player") && other.GetComponent<Health>())
        {
           // if(isOnAttack == true)
           // {
                other.GetComponent<Health>().GetDamage(10);
           // }
          //  isOnAttack = true;
            
        }
    }
}

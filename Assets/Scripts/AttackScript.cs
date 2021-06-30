using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    public bool isOnAttack = false;
    public GameObject triggerDamage;
    
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            triggerDamage.SetActive(true);
        }
    }
}


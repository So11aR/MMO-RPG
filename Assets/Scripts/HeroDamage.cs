using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDamage : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            print("Лови лимонку");
        }
    }
}

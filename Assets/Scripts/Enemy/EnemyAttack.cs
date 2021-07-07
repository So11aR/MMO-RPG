using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject triggerDamage;
    public GameObject Slime;

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            triggerDamage.SetActive(true);
            Slime.GetComponent<Animator>().SetTrigger("Attack");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnim : MonoBehaviour
{
    public GameObject AI;

    void OnTriggerStay(Collider col)
    {
        if(col.tag == "Player")
        {
            AI.GetComponent<Animator>().SetTrigger("Attack");
        }
    }

    void OnTriggerExit(Collider col)
    {
        if(col.tag == "Player")
        {
            AI.GetComponent<Animator>().SetTrigger("Move");
        }
    }
}

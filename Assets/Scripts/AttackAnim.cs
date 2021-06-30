using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnim : MonoBehaviour
{
    public GameObject AI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
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

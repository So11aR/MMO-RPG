using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float seeDistance = 5f;
    public float attackDistance = 2f;
    public float speed;
    private Transform target;
    public float EnemyLvl;

    public GameObject Slime;


    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if(Vector3.Distance(transform.position, target.transform.position) < seeDistance)
        {
            if(Vector3.Distance(transform.position, target.transform.position) > attackDistance)
            {
                transform.LookAt(target.transform);
                transform.Translate(new Vector3(0,0, speed * Time.deltaTime));
                Slime.GetComponent<Animator>().SetTrigger("Walk");
            }
        }
    }
}

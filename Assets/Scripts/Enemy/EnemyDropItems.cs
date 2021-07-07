using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDropItems : MonoBehaviour
{
    private GameObject obj;
    public GameObject[] objects;

    public void DropItems()
    {
        if (!obj)
        {
            obj = objects[Random.Range(0, objects.Length)];
            obj = Instantiate(obj, transform.position, obj.transform.rotation);
        }
    }
}

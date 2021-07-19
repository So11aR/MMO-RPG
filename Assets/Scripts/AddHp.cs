using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Health player =  other.GetComponent<Health>();

        if(player != null)
        {
            if(player.currHP < player.health)
            {
                player.GetDamage(-15);
                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

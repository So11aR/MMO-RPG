using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{ 
    public int coin;
    public Text coinText;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            coin++;
            coinText.text = coin.ToString();
            Destroy(other.gameObject);
        }
    }
}

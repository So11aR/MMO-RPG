using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{ 
    private int coin = -1;
    public Text coinText;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            print("lksdlkgs");
            coin++;
            coinText.text = coin.ToString();
            Destroy(other.gameObject);
        }
    }
}

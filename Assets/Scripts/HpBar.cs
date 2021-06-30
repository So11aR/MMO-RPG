using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpBar : MonoBehaviour
{
    public Color colorA = new Color(0, 0.8f, 0, 1);
    public Color colorB = new Color(0.8f, 0, 0, 1);  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Camera.main.transform);
    }
    public void ChangeValue (float value)
    {
        transform.localScale = new Vector3(value, 1, 1);
        GetComponent<SpriteRenderer>().color = Color.Lerp(colorB, colorA, value);
    }
}

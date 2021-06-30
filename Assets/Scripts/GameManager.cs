using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int expPoint = 0;
    private int Herolevel = 1;
    private int NeedExp = 200;
    public Image ExpImage;

    // Start is called before the first frame update
    void Awake()
    {
      if(Instance == null)
      {
        Instance = this;
      }
    }

    void Start()
    {
      ExpImage.fillAmount = expPoint;
    }

    public void IncExp (int amount)
    {
      expPoint = Mathf.Clamp(expPoint + amount, 0, NeedExp);
      ExpImage.fillAmount = 1.0f * expPoint / NeedExp;
      if (expPoint >= NeedExp)
      {
        Herolevel++;
        expPoint = 0;
        ExpImage.fillAmount = expPoint;
        NeedExp = NeedExp * 2;
      }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

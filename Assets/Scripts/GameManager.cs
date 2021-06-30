using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int expPoint;
    private int Herolevel = 1;
    private int NeedExp = 100;

    // Start is called before the first frame update
    void Awake()
    {
      if(Instance == null)
      {
        Instance = this;
      }
    }
    public void IncExp (int amount)
    {
        expPoint += amount;
        print(expPoint);
        if (expPoint >= NeedExp)
        {
            expPoint = 0;
            print(expPoint);
            Herolevel++;
            print(Herolevel + " level");
            NeedExp = NeedExp * 2;
            print(NeedExp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

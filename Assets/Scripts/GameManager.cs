using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int expPoint = 0;
    private int Herolevel = 1;
    private int NeedExp = 300;
    public Image ExpImage;
    public GameObject levelUpEffect;
    public Transform levelUpEffectPoint;
    public Text HeroLevelText;

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
        HeroUp();
      }
    }

    public void HeroUp()
    {
      Herolevel++;
      HeroLevelText.text = "Lv. " + Herolevel.ToString();
      GameObject clone = Instantiate(levelUpEffect, levelUpEffectPoint.transform);
      Destroy(clone, 5f);
      expPoint = 0;
      ExpImage.fillAmount = expPoint;
      NeedExp = NeedExp * 2;
      GameObject player = GameObject.FindGameObjectWithTag("Player");
      print(player);
      player.GetComponent<Health>().health *= 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

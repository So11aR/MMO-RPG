using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float currHP;
    public int health = 100;
    public bool isPlayer;
    [Header("Player")]
    public Image slider;
    public Text hpText;
    [Header("Enemy")]
    public HpBar hpBar;
    public float MonsterLevel;
    public float ExpHolder = 0;
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        currHP = health;
        if (isPlayer)
        {
            slider.fillAmount = 1.0f * currHP / health;
            hpText.text = currHP.ToString("0");
        }
        anim = GetComponent<Animator>();
    }
    public void GetDamage(int damage)
    {
        currHP = Mathf.Clamp(currHP - damage, 0, health);

        if (isPlayer)
        {
            slider.fillAmount = 1.0f * currHP / health;
            hpText.text = currHP.ToString("0");
            if(currHP <= 0)
            {
                Time.timeScale = 0;
            }
        } 
        else
        {
            hpBar.ChangeValue(currHP / health);
            if (currHP <= 0)
            {
                EnemyDie();
            }
        }
    }

    public void EnemyDie()
    {
        gameObject.GetComponentInParent<Animator>().SetTrigger("Die");
        gameObject.GetComponentInChildren<EnemyDropItems>().DropItems();
        gameObject.SetActive(false);
        Destroy(transform.parent.gameObject, 2.15f);
    }

    void OnDestroy()
    {
        GameManager.Instance.IncExp(100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

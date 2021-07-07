using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private float currHP;
    public int health = 100;
    public bool isPlayer;
    [Header("Player")]
    public Slider slider;
    public Text hpText;
    [Header("Enemy")]
    public HpBar hpBar;
    public float MonsterLevel;
    public float ExpHolder = 0;



    // Start is called before the first frame update
    void Start()
    {
        currHP = health;
        if (isPlayer)
        {
            slider.value = currHP / health;
            hpText.text = currHP.ToString("0");
        }

        

    }
    public void GetDamage(int damage)
    {
        currHP = Mathf.Clamp(currHP - damage, 0, health);

        if (isPlayer)
        {
            slider.value = currHP / health;
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
        GameObject enemyAnim = GameObject.Find("Slime");
        enemyAnim.GetComponent<Animator>().SetTrigger("Die");

        GameObject enemy = GameObject.Find("SlimeBody");
        enemy.SetActive(false);
        //enemy.GetComponent<Enemy>().speed = 0;

        GameObject dropItem = GameObject.Find("Drop Point");
        dropItem.GetComponent<EnemyDropItems>().DropItems();

        //GetDamage(0);
        // GameObject enemy = GameObject.Find("AttackObject");
        // Destroy(enemy);
        Destroy(enemyAnim, 2.15f);
        
        // if ( gameObject.GetComponent<Enemy>().EnemyLvl == 1 )
        // {
        //     Destroy(gameObject);
        // }
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

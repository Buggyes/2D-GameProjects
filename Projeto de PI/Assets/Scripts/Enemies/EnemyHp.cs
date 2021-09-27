using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    [SerializeField] private float enHp;
    [SerializeField] private bool isABoss;
    private float hBar;
    private HealthBarScript hb;
    void Start()
    {
        gameObject.SetActive(true);
        hBar = 1;
    }
    void Update()
    {
        if (enHp <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("PlProjectile"))
        {
            DamageEn();
        }
    }
    public void DamageEn()
	{
        if(enHp > 0 && isABoss == false)
		{
            enHp--;
		}
        else if (enHp > 0 && isABoss == true)
        {
            enHp--;
            hBar -= 0.10f;
            hb = GameObject.Find("BossHealthBar").GetComponent<HealthBarScript>();
            hb.SetSize(hBar);
        }
    }
}

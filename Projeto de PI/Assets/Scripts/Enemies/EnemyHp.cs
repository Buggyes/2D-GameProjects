using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    [SerializeField] private float enHp;
    void Start()
    {
        gameObject.SetActive(true);
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
        if(enHp > 0)
		{
            enHp--;
		}
	}
}

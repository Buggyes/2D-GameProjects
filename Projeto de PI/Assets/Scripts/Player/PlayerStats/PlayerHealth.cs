using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private float hp;
    private GameManager gm;
    private byte count;
    void Start()
    {
        gameObject.SetActive(true);
        count = 0;
        hp = 1;
    }
    void Update()
    {
        if(hp <= 0 && count == 0)
		{
            gm = GameObject.Find("GameManager").GetComponent<GameManager>();
            gm.SetDeath();
            gameObject.SetActive(false);
		}
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Damage();
        }
    }
    public void Damage()
	{
        if (hp > 0)
		{
            hp--;
		}
	}
}

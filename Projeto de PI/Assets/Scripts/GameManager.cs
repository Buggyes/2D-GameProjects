using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool plIsAlive;
    [SerializeField] private GameObject flyingEn, pl;
    [SerializeField] private Canvas restartButton;
    private float timer, spawnrate, cd;
    void Start()
    {
        spawnrate = 0;
        cd = 2;
        plIsAlive = true;
        restartButton.gameObject.SetActive(false);
    }
    void Update()
    {
        timer = Time.time;
        if(timer > spawnrate && pl.transform.position.x >= 78)
		{
            spawnrate = (timer + cd);
            Vector2 spawnPos = new Vector2(165, 1);
            Instantiate(flyingEn, spawnPos, new Quaternion());
		}
        if(plIsAlive == false)
		{
            restartButton.gameObject.SetActive(true);
		}
    }
    public void SetDeath()
	{
        plIsAlive = false;
	}
}

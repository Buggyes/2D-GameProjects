using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool plIsAlive;
    [SerializeField] private GameObject flyingEn;
    [SerializeField] private Canvas restartButton;
    private float timer, spawnrate, cd;
    void Start()
    {
        spawnrate = 0;
        cd = 3;
        plIsAlive = true;
        restartButton.gameObject.SetActive(false);
    }
    void Update()
    {
        timer = Time.time;
        if(timer > spawnrate)
		{
            spawnrate = (timer + cd);
            Vector2 spawnPos = new Vector2(165, (float)0.5);
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

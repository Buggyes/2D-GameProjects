using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject en, pl;
    [SerializeField] private float cd, posX, posY, spawnTrigger;
    private float timer, spawnrate;
	private void Start()
	{
        spawnrate = 0;
	}
	void Update()
    {
        timer = Time.time;
        if (timer > spawnrate && pl.transform.position.x >= spawnTrigger)
        {
            spawnrate = (timer + cd);
            Vector2 spawnPos = new Vector2(posX, posY);
            Instantiate(en, spawnPos, new Quaternion());
        }
    }
}

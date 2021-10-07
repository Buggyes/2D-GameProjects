using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject flyingEn, pl, cg, brickWall;
    [SerializeField] private Canvas restartButton, nextStageButton;
    [SerializeField] private int stage;
    private float timer, spawnrate, cd;
    private PlayerJump pj;
    private PlayerAttack pa;
    private bool isFighting, plIsAlive;
    void Start()
    {
        spawnrate = 0;
        cd = 2;
        plIsAlive = true;
        restartButton.gameObject.SetActive(false);
        nextStageButton.gameObject.SetActive(false);
    }
    void Update()
    {
        switch(stage)
		{
            case 1:
                timer = Time.time;
                if (timer > spawnrate && pl.transform.position.x >= 78)
                {
                    spawnrate = (timer + cd);
                    Vector2 spawnPos = new Vector2(165, 1);
                    Instantiate(flyingEn, spawnPos, new Quaternion());
                }
                if (plIsAlive == false)
                {
                    restartButton.gameObject.SetActive(true);
                }
                if (pl.transform.position.x >= 210 && isFighting == false)
                {
                    Vector2 spawnPos = new Vector2(200, (float)8);
                    Instantiate(brickWall, spawnPos, new Quaternion());
                    isFighting = true;
                }
                if (cg.activeInHierarchy == false)
                {
                    pj = GameObject.Find("Player").GetComponent<PlayerJump>();
                    pa = GameObject.Find("Player").GetComponent<PlayerAttack>();
                    pa.ableToAttack = false;
                    pj.ableToMove = false;
                    NextStage();
                }
                break;
            case 2:
                if(plIsAlive == false)
				{
                    restartButton.gameObject.SetActive(true);
                    pj = GameObject.Find("Player").GetComponent<PlayerJump>();
                    pj.ableToMove = false;
                }
                break;
            default:
                break;
		}
    }
    public void SetDeath()
	{
        plIsAlive = false;
	}
    private void NextStage()
	{
        nextStageButton.gameObject.SetActive(true);
	}
}

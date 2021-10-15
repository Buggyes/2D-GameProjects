using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject pl, cg, brickWall;
    [SerializeField] private Canvas restartButton, nextStageButton;
    [SerializeField] private int stage;
    private PlayerJump pj;
    private PlayerAttack pa;
    private bool isFighting, plIsAlive;
    public bool endedTheStage;
    void Start()
    {
        plIsAlive = true;
        endedTheStage = false;
        restartButton.gameObject.SetActive(false);
        nextStageButton.gameObject.SetActive(false);
    }
    void Update()
    {
        switch(stage)
		{
            case 1:
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
                    if(pl.activeInHierarchy == true)
					{
                        pj = GameObject.Find("Player").GetComponent<PlayerJump>();
                        pj.ableToMove = false;
                    }
                }
                if (pl.transform.position.x >= 770 && endedTheStage == false)
				{
                    nextStageButton.gameObject.SetActive(true);
                    pj = GameObject.Find("Player").GetComponent<PlayerJump>();
                    pj.ableToMove = false;
                    endedTheStage = true;
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

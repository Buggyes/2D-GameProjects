using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool plIsAlive;
    [SerializeField] private Canvas restartButton;
    void Start()
    {
        plIsAlive = true;
        restartButton.gameObject.SetActive(false);
    }
    void Update()
    {
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

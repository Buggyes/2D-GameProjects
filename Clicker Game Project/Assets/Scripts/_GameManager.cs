using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GameManager : MonoBehaviour
{
    private float autoClick, autoClickValue, clickValue, clickMult, money, acCost, acvCost, cvCost, cmCost, targetHp, timer, punchRate;
    void Start()
    {
        acCost = 20;
        acvCost = 50;
        cvCost = 10;
        cmCost = 100;
        autoClick = 0;
        autoClickValue = (float)0.5;
        clickValue = 1;
        clickMult = 0;
        money = 0;
    }
    void Update()
    {
        timer = Time.time;
        if(timer > punchRate && punchRate > 0)
		{
            punchRate = (timer + autoClick);
            money += autoClickValue;
            FindObjectOfType<AutoClickFist>().Ora();
		}
    }
    public void PlayerClick()
	{
        FindObjectOfType<PlayerPunch>().Punch();
        money += (clickValue + (clickValue * clickMult));
	}
    public void UpgradeAutoClick()
    {
        if(autoClick == 0 && money >= acCost)
		{
            punchRate = (timer + autoClick);
            autoClick = 10;
            acCost += acCost*(float)0.10;
            money -= acCost;
		}
        else if(autoClick == 0.1)
		{
            autoClick = (float)0.1;
		}
        else if(money >= acCost)
		{
            autoClick -= (float)0.1;
            money -= acCost;
        }
		else
        {
            print("ce n tem denero");
        }
    }
    public void UpgradeClickValue()
    {
        if(money >= cvCost)
		{

            clickValue += 1;
            money -= cvCost;
            cvCost += (cvCost * (float)0.10);
		}
		else
		{
            print("ce n tem denero");
		}
    }
    public void UpgradeClickMultiplier()
    {
        if(money >= cmCost)
		{
            clickMult += (float)0.01;
            money -= cmCost;
            cmCost += (cmCost * (float)0.10);
        }
		else
		{
            print("ce n tem denero");
        }
    }
    public void UpgradeAutoClickValue()
    {
        if(money >= acvCost)
		{
            autoClickValue += (autoClickValue * (float)0.5);
            money -= acvCost;
            acvCost += (acvCost * (float)0.10);
        }
        else
		{
            print("ce n tem denero");
		}
    }
}

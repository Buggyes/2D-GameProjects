using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GameManager : MonoBehaviour
{
    public float autoClick, clickValue, clickMult, hp;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void PlayerClick()
	{
        print("Ok player click");
	}
    public void UpgradeAutoClick()
    {
        print("Ok Auto Click");
    }
    public void UpgradeClickValue()
    {
        print("Ok Click Value");
    }
    public void UpgradeClickMultiplier()
    {
        print("Ok Click Multiplier");
    }
    public void UpgradeHealthPoints()
    {
        print("Ok Health Points");
    }
}

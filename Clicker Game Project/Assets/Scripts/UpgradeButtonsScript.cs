using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeButtonsScript : MonoBehaviour
{
	public void AutoClickButton()
	{
		FindObjectOfType<_GameManager>().UpgradeAutoClick();
	}
	public void ClickValueButton()
	{
		FindObjectOfType<_GameManager>().UpgradeClickValue();
	}
	public void ClickMultiplierButton()
	{
		FindObjectOfType<_GameManager>().UpgradeClickMultiplier();
	}
	public void HealthPointsButton()
	{
		FindObjectOfType<_GameManager>().UpgradeHealthPoints();
	}
	public void PlayerButton()
	{
		FindObjectOfType<_GameManager>().PlayerClick();
	}
}

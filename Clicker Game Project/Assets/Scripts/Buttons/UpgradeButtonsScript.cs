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
	public void AutoClickValueButton()
	{
		FindObjectOfType<_GameManager>().UpgradeAutoClickValue();
	}
	public void PlayerButton()
	{
		FindObjectOfType<_GameManager>().PlayerClick();
	}
}

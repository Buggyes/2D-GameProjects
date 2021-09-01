using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
	[SerializeField] private GameObject player;
	private void OnCollisionEnter2D(Collision2D otherCol)
	{
		if (otherCol.gameObject == player)
		{
			player.transform.parent = transform;
		}
	}
	private void OnCollisionExit2D(Collision2D otherCol)
	{
		player.transform.parent = null;
	}
}

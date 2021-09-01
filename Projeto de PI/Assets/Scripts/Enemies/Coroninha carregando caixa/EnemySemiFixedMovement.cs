using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySemiFixedMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D platRig;
    [SerializeField] private float rightLimit, leftLimit;
    [SerializeField] private GameObject player;
    [SerializeField] private bool goingRight, goingLeft;
    void Update()
    {
        if (goingLeft == true)
        {
            platRig.transform.Translate(Vector2.left * (Time.deltaTime * 6));
        }
        else if (goingRight == true)
        {
            platRig.transform.Translate(Vector2.right * (Time.deltaTime * 6));
        }
    }
	private void FixedUpdate()
	{
		if(platRig.transform.position.x > rightLimit)
		{
            goingLeft = true;
            goingRight = false;
		}
        else if (platRig.transform.position.x < leftLimit)
        {
            goingLeft = false;
            goingRight = true;
        }
    }
	private void OnCollisionEnter2D(Collision2D otherCol)
	{
        if(otherCol.gameObject == player)
		{
            player.transform.parent = transform;
		}
	}
	private void OnCollisionExit2D(Collision2D otherCol)
	{
        player.transform.parent = null;
	}
}

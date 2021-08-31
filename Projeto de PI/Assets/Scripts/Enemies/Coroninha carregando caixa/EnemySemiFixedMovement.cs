using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySemiFixedMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D platRig;
    [SerializeField] private BoxCollider2D platCol;
    [SerializeField] private float rightLimit, leftLimit, startingDirection;
    [SerializeField] private GameObject player;
    private bool goingRight, goingLeft;
    void Update()
    {
        if (goingLeft == true)
        {
            platRig.velocity = new Vector2(-6, 0);
            platRig.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (goingRight == true)
        {
            platRig.velocity = new Vector2(6, 0);
            platRig.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            platRig.velocity = new Vector2(startingDirection, 0);
            platRig.transform.rotation = Quaternion.Euler(0, 180, 0);
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

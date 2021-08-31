using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMobility : MonoBehaviour
{
    [SerializeField] private Rigidbody2D plRig;
    private bool ableToJump, ableToRush, ableToDJump;
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && ableToJump == true)
        {
            plRig.velocity = new Vector2(plRig.velocity.x, 15);
            ableToJump = false;
            ableToDJump = true;
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow) && ableToDJump == true)
		{
            plRig.velocity = new Vector2(plRig.velocity.x, 15);
            ableToDJump = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        foreach (ContactPoint2D hitContact in collision.contacts)
        {
            if (hitContact.normal.y > 0 && ableToJump == false)
            {
                ableToJump = true;
                ableToDJump = false;
            }
        }
    }
	private void OnCollisionExit2D(Collision2D collision)
	{
        if(ableToRush == true)
		{
            ableToRush = false;
		}
	}
	private void OnCollisionStay2D(Collision2D collision)
	{
        if (ableToRush == false)
        {
            ableToRush = true;
        }
        if (Input.GetKey(KeyCode.LeftShift) && ableToRush == true)
        {
            if (plRig.velocity.x > 0 && Input.GetKey(KeyCode.RightArrow))
            {
                plRig.AddForce(new Vector2(200, plRig.velocity.y));
            }
            else if (plRig.velocity.x < 0 && Input.GetKey(KeyCode.LeftArrow))
            {
                plRig.AddForce(new Vector2(-200, plRig.velocity.y));
            }
        }
    }
}

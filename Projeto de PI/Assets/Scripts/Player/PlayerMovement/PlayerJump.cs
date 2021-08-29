using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private Rigidbody2D plRig;
    private bool ableToJump;
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && ableToJump == true)
		{
            plRig.velocity = new Vector3(plRig.velocity.x, 15, 0);
            ableToJump = false;
        }
    }
	private void OnCollisionEnter2D(Collision2D collision)
	{
		foreach(ContactPoint2D hitContact in collision.contacts)
		{
            if(hitContact.normal.y > 0 && ableToJump == false)
			{
                ableToJump = true;
			}
		}
	}
}

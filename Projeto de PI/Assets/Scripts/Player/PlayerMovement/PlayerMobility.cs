using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMobility : MonoBehaviour
{
    [SerializeField] private Rigidbody2D plRig;
    [SerializeField] private Animator an;
    [SerializeField] Animation jump;
    private bool ableToJump, ableToDJump;
	private void Start()
	{
        an.GetComponent<Animator>();
	}
	void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && ableToJump == true)
        {
            plRig.velocity = new Vector2(plRig.velocity.x, 15);
            ableToJump = false;
            ableToDJump = true;
            an.SetBool("IsJumping", true);
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow) && ableToDJump == true)
		{
            plRig.velocity = new Vector2(plRig.velocity.x, 15);
            ableToDJump = false;
            an.SetBool("IsJumping", false);
            an.SetBool("IsJumping", true);
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
                an.SetBool("IsJumping", false);
            }
        }
    }
}

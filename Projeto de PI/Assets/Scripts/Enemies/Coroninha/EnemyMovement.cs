using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D enRig;
    private bool goingRight, goingLeft;
    void Update()
    {
        if(goingLeft == true)
		{
            enRig.velocity = new Vector2(-6, 0);
            enRig.transform.rotation = Quaternion.Euler(0,180,180);
		}
        else if(goingRight == true)
		{
            enRig.velocity = new Vector2(6, 0);
            enRig.transform.rotation = Quaternion.Euler(0,0,0);
        }
        else
		{
            enRig.velocity = new Vector2(-6, 0);
            enRig.transform.rotation = Quaternion.Euler(0,180,180);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        foreach (ContactPoint2D hitContact in collision.contacts)
        {
            if (hitContact.normal.x > 0)
            {
                goingLeft = false;
                goingRight = true;
            }
            else if (hitContact.normal.x < 0)
			{
                goingRight = false;
                goingLeft = true;
            }
        }
    }
}

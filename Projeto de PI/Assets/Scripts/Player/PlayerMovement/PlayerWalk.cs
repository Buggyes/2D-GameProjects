using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    [SerializeField] private Rigidbody2D plRig;
    [SerializeField] private GameObject rightAtkPoint, leftAtkPoint;
    [SerializeField] private Animator an;
    [SerializeField] private GameObject pen;
    public bool isFacingRight;

	private void Start()
	{
        isFacingRight = true;
        an.GetComponent<Animator>();
        rightAtkPoint.transform.parent = transform;
        leftAtkPoint.transform.parent = transform;
    }
	void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            plRig.transform.Translate(Vector2.left * (Time.deltaTime * 10));
            an.SetBool("IsWalking", true);
            GetComponent<SpriteRenderer>().flipX = true;
            isFacingRight = false;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            plRig.transform.Translate(Vector2.right * (Time.deltaTime * 10));
            an.SetBool("IsWalking", true);
            GetComponent<SpriteRenderer>().flipX = false;
            isFacingRight = true;
        }
        else
		{
            an.SetBool("IsWalking", false);
        }
        if(Input.GetKeyDown(KeyCode.Space))
		{
            switch(isFacingRight)
			{
                case true:
                    an.SetTrigger("IsAttacking");
                    Instantiate(pen, rightAtkPoint.transform.position, new Quaternion());
                    break;
                case false:
                    an.SetTrigger("IsAttacking");
                    Instantiate(pen, leftAtkPoint.transform.position, new Quaternion());
                    break;
			}
		}
    }
}

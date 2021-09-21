using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    [SerializeField] private Rigidbody2D plRig;
    [SerializeField] private Animator an;
	private void Start()
	{
        an.GetComponent<Animator>();
	}
	void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            plRig.transform.Translate(Vector2.left * (Time.deltaTime * 10));
            an.SetBool("IsWalking", true);
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            plRig.transform.Translate(Vector2.right * (Time.deltaTime * 10));
            an.SetBool("IsWalking", true);
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else
		{
            an.SetBool("IsWalking", false);
        }
    }
}

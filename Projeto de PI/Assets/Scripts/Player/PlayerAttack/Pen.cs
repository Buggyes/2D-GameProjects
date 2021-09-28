using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pen : MonoBehaviour
{
    private PlayerWalk pw;
    [SerializeField] private Rigidbody2D penRig;
    void Start()
    {
        pw = GameObject.Find("Player").GetComponent<PlayerWalk>();
        if(pw.isFacingRight == true)
		{
            GetComponent<SpriteRenderer>().flipX = false;
            penRig.velocity = new Vector2(20, 0);
		}
        else if(pw.isFacingRight == false)
		{
            GetComponent<SpriteRenderer>().flipX = true;
            penRig.velocity = new Vector2(-20, 0);
        }
    }
	private void Update()
	{
		if(penRig.position.x > (pw.plRig.position.x+25))
		{
            Destroy(gameObject);
		}
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
        Destroy(gameObject);
	}
}

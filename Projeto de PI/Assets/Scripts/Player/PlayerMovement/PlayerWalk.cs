using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    [SerializeField] private Animator an;
    [SerializeField] private float moveSpeed;
    [SerializeField] private bool hasAnimator;
    public Rigidbody2D plRig;
    private PlayerJump pm;
    public bool isFacingRight;
    private void Start()
    {
        isFacingRight = true;
        if (hasAnimator == true)
        {
            an.GetComponent<Animator>();
        }
    }
    void Update()
    {
        pm = GameObject.Find("Player").GetComponent<PlayerJump>();
        if (pm.ableToMove == true)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                plRig.transform.Translate(Vector2.left * (Time.deltaTime * moveSpeed));
                if(hasAnimator == true)
				{
                    an.SetBool("IsWalking", true);
                }
                GetComponent<SpriteRenderer>().flipX = true;
                isFacingRight = false;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                plRig.transform.Translate(Vector2.right * (Time.deltaTime * moveSpeed));
                if (hasAnimator == true)
                {
                    an.SetBool("IsWalking", true);
                }
                GetComponent<SpriteRenderer>().flipX = false;
                isFacingRight = true;
            }
            else
            {
                if (hasAnimator == true)
                {
                    an.SetBool("IsWalking", false);
                }
            }
        }
    }
}

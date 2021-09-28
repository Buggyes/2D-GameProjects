using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public Rigidbody2D plRig;
    [SerializeField] private Animator an;
    private PlayerJump pm;
    public bool isFacingRight;
    private void Start()
    {
        isFacingRight = true;
        an.GetComponent<Animator>();
    }
    void Update()
    {
        pm = GameObject.Find("Player").GetComponent<PlayerJump>();
        if (pm.ableToMove == true)
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
        }
    }
}

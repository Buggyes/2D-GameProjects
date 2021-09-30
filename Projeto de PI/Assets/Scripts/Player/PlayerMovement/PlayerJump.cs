using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private Rigidbody2D plRig;
    [SerializeField] private Animator an;
    [SerializeField] private float jumpStr;
    private bool ableToJump, ableToDJump;
    public bool ableToMove;
    private void Start()
    {
        an.GetComponent<Animator>();
    }
    void Update()
    {
        if (ableToMove == true)
        {
            if (Input.GetKey(KeyCode.UpArrow) && ableToJump == true)
            {
                plRig.velocity = new Vector2(plRig.velocity.x, jumpStr);
                FindObjectOfType<AudioManager>().PlaySound("PlayerJump");
                ableToJump = false;
                ableToDJump = true;
                an.SetBool("IsJumping", true);
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow) && ableToDJump == true)
            {
                plRig.velocity = new Vector2(plRig.velocity.x, jumpStr);
                FindObjectOfType<AudioManager>().PlaySound("PlayerJump");
                ableToDJump = false;
                an.SetBool("IsJumping", false);
                an.SetBool("IsJumping", true);
            }
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PW : MonoBehaviour
{
    public Rigidbody2D plRig;
    private PJ pj;
    public bool isFacingRight;
    private void Start()
    {
        isFacingRight = true;
    }
    void Update()
    {
        pj = GameObject.Find("Player").GetComponent<PJ>();
        if (pj.ableToMove == true)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                plRig.transform.Translate(Vector2.left * (Time.deltaTime * 10));
                GetComponent<SpriteRenderer>().flipX = true;
                isFacingRight = false;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                plRig.transform.Translate(Vector2.right * (Time.deltaTime * 10));
                GetComponent<SpriteRenderer>().flipX = false;
                isFacingRight = true;
            }
            else
            {
                //an.SetBool("IsWalking", false);
            }
        }
    }
}

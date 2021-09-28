using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkAndAttack : MonoBehaviour
{
    public Rigidbody2D plRig;
    [SerializeField] private GameObject rightAtkPoint, leftAtkPoint;
    [SerializeField] private Animator an;
    [SerializeField] private GameObject pen;
    private PlayerMobility pm;
    public bool isFacingRight;
    private float timer, cd, atkDelay;
    private void Start()
    {
        atkDelay = 0;
        cd = (float) 0.5;
        isFacingRight = true;
        an.GetComponent<Animator>();
        rightAtkPoint.transform.parent = transform;
        leftAtkPoint.transform.parent = transform;
    }
    void Update()
    {
        pm = GameObject.Find("Player").GetComponent<PlayerMobility>();
        timer = Time.time;
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
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (isFacingRight == true && timer > atkDelay)
                {
                    atkDelay = timer + cd;
                    an.SetTrigger("IsAttacking");
                    Instantiate(pen, rightAtkPoint.transform.position, new Quaternion());
                    FindObjectOfType<AudioManager>().PlaySound("PlayerAttack");
                }
                else if (isFacingRight == false && timer > atkDelay)
                {
                    atkDelay = timer + cd;
                    an.SetTrigger("IsAttacking");
                    Instantiate(pen, leftAtkPoint.transform.position, new Quaternion());
                    FindObjectOfType<AudioManager>().PlaySound("PlayerAttack");
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private GameObject rightAtkPoint, leftAtkPoint;
    [SerializeField] private Animator an;
    [SerializeField] private GameObject pen;
    [SerializeField] private bool ableToAttack;
    private PlayerWalk pw;
    private float timer, cd, atkDelay;
    private void Start()
    {
        atkDelay = 0;
        cd = (float)0.5;
        an.GetComponent<Animator>();
        rightAtkPoint.transform.parent = transform;
        leftAtkPoint.transform.parent = transform;
    }
    void Update()
    {
        pw = GameObject.Find("Player").GetComponent<PlayerWalk>();
        timer = Time.time;
        if (Input.GetKeyDown(KeyCode.Space) && ableToAttack == true)
        {
            if (pw.isFacingRight == true && timer > atkDelay)
            {
                atkDelay = timer + cd;
                an.SetTrigger("IsAttacking");
                Instantiate(pen, rightAtkPoint.transform.position, new Quaternion());
                FindObjectOfType<AudioManager>().PlaySound("PlayerAttack");
            }
            else if (pw.isFacingRight == false && timer > atkDelay)
            {
                atkDelay = timer + cd;
                an.SetTrigger("IsAttacking");
                Instantiate(pen, leftAtkPoint.transform.position, new Quaternion());
                FindObjectOfType<AudioManager>().PlaySound("PlayerAttack");
            }
        }
    }
}

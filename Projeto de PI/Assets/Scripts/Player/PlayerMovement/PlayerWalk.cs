using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    [SerializeField] private Rigidbody2D plRig;
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            plRig.velocity = new Vector3(-10, plRig.velocity.y, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            plRig.velocity = new Vector3(10, plRig.velocity.y, 0);
        }
        else
        {
            plRig.velocity = new Vector3(0, plRig.velocity.y, 0);
        }
    }
}

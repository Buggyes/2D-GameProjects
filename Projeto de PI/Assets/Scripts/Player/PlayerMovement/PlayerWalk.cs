using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    [SerializeField] private Rigidbody2D plRig;
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            plRig.velocity = new Vector2(-10, plRig.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            plRig.velocity = new Vector2(10, plRig.velocity.y);
        }
        else
        {
            plRig.velocity = new Vector2(0, plRig.velocity.y);
        }
    }
}

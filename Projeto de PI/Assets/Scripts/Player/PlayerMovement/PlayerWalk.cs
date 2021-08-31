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
            plRig.velocity = new Vector2(-15, plRig.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            plRig.velocity = new Vector2(15, plRig.velocity.y);
        }
        else
        {
            plRig.velocity = new Vector2(0, plRig.velocity.y);
            plRig.velocity = new Vector2(plRig.velocity.x, plRig.velocity.y);
        }
    }
}

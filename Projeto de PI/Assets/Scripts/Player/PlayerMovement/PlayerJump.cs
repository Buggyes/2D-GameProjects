using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private Rigidbody2D plRig;
    [SerializeField] private BoxCollider2D plCol;
    [SerializeField] private BoxCollider2D floorCol;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && plCol.IsTouching(floorCol))
		{
            plRig.velocity = new Vector3(plRig.velocity.x, 10, 0);
        }
    }
}

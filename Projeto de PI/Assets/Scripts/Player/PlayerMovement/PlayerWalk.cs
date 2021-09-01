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
            plRig.transform.Translate(Vector2.left * (Time.deltaTime * 8));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            plRig.transform.Translate(Vector2.right * (Time.deltaTime * 8));
        }
    }
}

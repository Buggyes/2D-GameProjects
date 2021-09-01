using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovementScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D platRig;
    [SerializeField] private float rightLimit, leftLimit;
    [SerializeField] private bool goingRight, goingLeft;
    void Update()
    {
        if (goingLeft == true)
        {
            platRig.transform.Translate(Vector2.left * (Time.deltaTime * 6));
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (goingRight == true)
        {
            platRig.transform.Translate(Vector2.right * (Time.deltaTime * 6));
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
    private void FixedUpdate()
    {
        if (platRig.transform.position.x > rightLimit)
        {
            goingLeft = true;
            goingRight = false;
        }
        else if (platRig.transform.position.x < leftLimit)
        {
            goingLeft = false;
            goingRight = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemyMobility : MonoBehaviour
{
    [SerializeField] private Rigidbody2D enRig;
    [SerializeField] private float speed, limit;
    void Update()
    {
        enRig.velocity = new Vector2(speed, 0);
        if (enRig.transform.position.x <= limit)
        {
            Destroy(gameObject);
        }
    }
}

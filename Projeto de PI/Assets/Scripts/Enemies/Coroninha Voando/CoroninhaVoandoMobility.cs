using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroninhaVoandoMobility : MonoBehaviour
{
    [SerializeField] private Rigidbody2D enRig;
    [SerializeField] private float limit, speed;
    void Update()
    {
        enRig.velocity = new Vector2(speed, 0);
        if(enRig.position.x <= limit)
		{
            Destroy(gameObject);
		}
    }
}

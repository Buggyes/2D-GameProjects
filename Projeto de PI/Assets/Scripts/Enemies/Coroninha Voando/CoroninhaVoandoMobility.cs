using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroninhaVoandoMobility : MonoBehaviour
{
    [SerializeField] private Rigidbody2D enRig;
    [SerializeField] private float limit;
    void Update()
    {
        enRig.velocity = new Vector2(-10, 0);
        if(enRig.position.x <= limit)
		{
            Destroy(gameObject);
		}
    }
}

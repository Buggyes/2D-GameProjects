using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPunch : MonoBehaviour
{
    [SerializeField] private Rigidbody2D fistRig;
    [SerializeField] private GameObject fist, plank, glass;
    private bool punched;
    void Start()
    {
        punched = false;
    }
    void Update()
    {
        if(punched == true)
		{
            punched = false;
            fist.transform.position = new Vector2(-5, 0);
            fistRig.velocity = new Vector2(0, 0);
        }
    }
	private void OnCollisionEnter2D(Collision2D col)
	{
        if (col.gameObject.tag == "Target")
        {
            punched = true;
        }
    }
	public void Punch()
	{
        fistRig.velocity = new Vector2(60, 0);
	}
}

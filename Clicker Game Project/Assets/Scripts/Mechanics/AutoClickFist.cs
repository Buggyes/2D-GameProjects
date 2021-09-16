using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClickFist : MonoBehaviour
{
    [SerializeField] private Rigidbody2D fistRig;
    [SerializeField] private GameObject fist;
    private bool punched;
    void Start()
    {
        punched = false;
    }
    void Update()
    {
        if (punched == true)
        {
            punched = false;
            fist.transform.position = new Vector2(-7, 1);
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Target")
        {
            punched = true;
        }
    }
    public void Ora()
    {
        fistRig.velocity = new Vector2(80, 0);
    }
}

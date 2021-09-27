using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPattern : MonoBehaviour
{
    [SerializeField] private GameObject minion, pl;
    [SerializeField] private Animator an;
    private bool atkdFromTheTop;
    private float timer, atkCd, atkSpeed;
    void Start()
    {
        an.GetComponent<Animator>();
        atkCd = (float)1.5;
        atkSpeed = 0;
    }
    void Update()
    {
        timer = Time.time;
        if(pl.transform.position.x >= 210 && timer > atkSpeed && atkdFromTheTop == false)
		{
            atkSpeed = timer + atkCd;
            Vector2 spawnPos = new Vector2(253, 5);
            Instantiate(minion, spawnPos, new Quaternion());
            atkdFromTheTop = true;
            an.SetTrigger("Attack");
        }
        else if (pl.transform.position.x >= 210 && timer > atkSpeed && atkdFromTheTop == true)
        {
            atkSpeed = timer + atkCd;
            Vector2 spawnPos = new Vector2(253, -2);
            Instantiate(minion, spawnPos, new Quaternion());
            atkdFromTheTop = false;
            an.SetTrigger("Attack");
        }
    }
}

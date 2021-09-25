using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private Animator an;
    [SerializeField] private GameObject rightAtkPoint, leftAtkPoint;
    [SerializeField] private GameObject pen;
    void Start()
    {
        an.GetComponent<Animator>();
    }
    void Update()
    {
        
    }
}

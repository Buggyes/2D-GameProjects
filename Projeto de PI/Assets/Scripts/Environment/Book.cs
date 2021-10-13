using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Book : MonoBehaviour
{
    [SerializeField] private float addAmount;
    [SerializeField] private Text timerTxt;
    private Cronometer timeM;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        timeM = timerTxt.GetComponent<Cronometer>();
        if (collision.gameObject.tag.Equals("Player"))
        {
            timeM.AddTime(addAmount);
            Destroy(gameObject);
        }
    }
}

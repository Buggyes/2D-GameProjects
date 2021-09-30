using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyTextScript : MonoBehaviour
{
    [SerializeField] private Text mon;
    private float moneyQtt = 0;
    private _GameManager gm;
    void Start()
    {
        mon = GetComponent<Text>();
    }
    void Update()
    {
        gm = GameObject.Find("GameManager").GetComponent<_GameManager>();
        moneyQtt = gm.SetMoney(moneyQtt);
        moneyQtt = Mathf.Round(moneyQtt);
        mon.text = "Money: "+moneyQtt;
    }
}

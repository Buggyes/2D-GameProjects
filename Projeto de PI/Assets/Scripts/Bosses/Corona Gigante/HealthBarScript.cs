using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarScript : MonoBehaviour
{
    [SerializeField] private Transform bar;
    private void Start()
    {
        bar.transform.Find("Bar");
    }
    public void SetSize(float SetSize)
	{
        bar.localScale = new Vector2(SetSize, 1f);
	}
}

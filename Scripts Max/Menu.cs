using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public float times = 1f;


    void Update()
    {
        times -= Time.deltaTime;
        if (Input.touchCount == 1 && times <= 0 || Input.GetMouseButtonDown(0) && times <= 0)
        {
            Application.LoadLevel(1);
        }
        if (times <= 0)
        {
            times = 0;
        }
    }
}
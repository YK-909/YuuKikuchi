﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContlolePassive1 : MonoBehaviour
{
    private Player1passive sw;
    public static int passive;

    // Start is called before the first frame update
    void Start()
    {
        GameObject canvas = GameObject.Find("1P_passive");
        sw = canvas.GetComponent<Player1passive>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (sw.WeponType)
        {
            case 0:
                passive = 1;
                break;

            case 1:
                passive = 2;
                break;

            case 2:
                passive = 3;
                break;
        }
    }

    public static int GetPassive()
    {
        return passive;
    }
}

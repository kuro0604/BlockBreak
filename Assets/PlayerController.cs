﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 pos;
    private Vector3 WorldPointPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = Input.mousePosition;
        WorldPointPos = Camera.main.ScreenToWorldPoint(pos);

        if(WorldPointPos.x <= -2.1f)
        {
            WorldPointPos.x = -2.1f;
        }
        else if (WorldPointPos.x >= 2.1f)
        {
            WorldPointPos.x = 2.1f;
        }
        WorldPointPos.y = -3.0f;
        WorldPointPos.z = 0.0f;

        gameObject.transform.position = WorldPointPos;
    }
}

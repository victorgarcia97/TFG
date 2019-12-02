﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookPlayer : MonoBehaviour
{
    public GameObject player;

    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (player != null)
        {
            gameObject.transform.LookAt(player.transform.position);
        }


    }
}

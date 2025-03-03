﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DimBoxes
{
    public class TestDynamicBehaviour :  MonoBehaviour
    {

        private float t = 0f;
        private Vector3 angles = Vector3.zero;
        private Vector3 scale = Vector3.one;
        bool run = true;
        float speed = 30f;


	void Start () {
		angles = transform.rotation.eulerAngles;
        scale = transform.localScale;
	}
	
	void Update () {
        
        t += speed*Time.deltaTime;
        transform.rotation = Quaternion.Euler(new Vector3(angles.x, (angles.y + t)%360, angles.z));
        transform.localScale = new Vector3(scale.x, scale.y * (1.0f + 0.5f * Mathf.Sin(Mathf.Deg2Rad*t)), scale.z);
        if (!run && t >= 360) enabled = false;
        t = t % 360;
	}

    public void Test(bool val)
    {
        if (val)
        {
            enabled = true;
        }
        run = val;
    }
}
}
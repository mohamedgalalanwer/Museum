﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_With_ : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.position += new Vector3(h * Time.deltaTime, 0f, v );
		
	}
}

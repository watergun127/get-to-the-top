﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScaler : MonoBehaviour {
	public float timeScale;
	// Use this for initialization
	void Start () {
		Time.timeScale=timeScale;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

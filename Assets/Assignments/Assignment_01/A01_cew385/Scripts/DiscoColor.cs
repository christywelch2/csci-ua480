﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoColor : MonoBehaviour {

	// Use this for initialization
	void Start () {

        GetComponent<Renderer>().material.color = Color.black;
	}

}

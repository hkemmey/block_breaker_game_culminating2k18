﻿// MUSIC PLAYER SCRIPT

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Player : MonoBehaviour {
	static Music_Player instance = null;

	void Awake () {
		if (instance != null) {
			Destroy (gameObject);
			print ("Duplicate music player self-destructing");
		}
		else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

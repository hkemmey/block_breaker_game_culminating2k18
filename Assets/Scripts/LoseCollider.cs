﻿// LOSE COLLIDER SCRIPT

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	private LevelManager level_manager;
	// Use this for initialization
	void Start () {
		level_manager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D trigger) {
		print ("Trigger");
		level_manager.LoadLevel("Lose Screen");
	}

	void OnCollisionEnter2D (Collision2D collision) {
		print("collision");
	}
}
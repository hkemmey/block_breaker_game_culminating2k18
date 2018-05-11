// BALL SCRIPT

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	private Vector3 paddle_to_ball_distance;
	private bool has_started = false;
	private Rigidbody2D b_Rigidbody2D;


	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddle_to_ball_distance = this.transform.position - paddle.transform.position;
		b_Rigidbody2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		if (!has_started) {
			// keeps the ball attached to the paddle until told otherwise
			this.transform.position = paddle.transform.position + paddle_to_ball_distance; 

			// waits for mouse click to launch ball
			if(Input.GetMouseButtonDown(0)) {
				has_started = true;
				b_Rigidbody2D.velocity = new Vector2 (2f, 10f);
			}
		}
	}

	void OnCollisionEnter2D (Collision2D collision) {
		Vector2 tweak_velocity = new Vector2 (Random.Range(0f,.2f), Random.Range(0f, 2f));
		b_Rigidbody2D.velocity += tweak_velocity; 
	}
}

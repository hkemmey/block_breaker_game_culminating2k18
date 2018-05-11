// PADDLE SCRIPT

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public bool autoPlay = false;
	private Ball ball;
	// Use this for initialization
	void Start () {
		ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
		if(!autoPlay) {
			MoveWithMouse();
		}
		else {
			AutoPlay();
		}
	}

	void MoveWithMouse () {
		Vector3 paddle_position = new Vector3 (0.75f, this.transform.position.y, 0f);
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;

		paddle_position.x = Mathf.Clamp(mousePosInBlocks, .75f, 15.25f);

		this.transform.position = paddle_position;
	}

	void AutoPlay() {
		Vector3 paddle_position = new Vector3 (0.75f, this.transform.position.y, 0f);
		Vector3 ballPosition = ball.transform.position;

		paddle_position.x = Mathf.Clamp(ballPosition.x, .75f, 15.25f);
		this.transform.position = paddle_position;
	}
}

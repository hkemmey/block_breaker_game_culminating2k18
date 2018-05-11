// BRICKS SCRIPT

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	public int maxHits;
	private int timesHit;
	private LevelManager level_manager;
	private SpriteRenderer b_sprite_renderer;
	public static int breakableCount;
	private bool isBreakable;

	// Use this for initialization
	void Awake () {
		breakableCount = 0;
	}
	void Start () {
		timesHit = 0;	

		level_manager = GameObject.FindObjectOfType<LevelManager>();
		b_sprite_renderer = gameObject.GetComponent<SpriteRenderer>();
		isBreakable = (gameObject.tag == "Breakable");
		if(isBreakable) {
			breakableCount ++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col) {
		
		if(isBreakable) {
			Handle_hits();
		}
	}

	// TODO Remove method once winning is possible

	void SimulateWin() {
		level_manager.LoadNextLevel();
	}

	void Handle_hits () {
		timesHit ++;
		if(timesHit >= maxHits) {
			Destroy(gameObject);
			breakableCount --;
			//print(breakableCount);
			level_manager.BrickDestroyed();
		}
		else {
			Switch_brick_color_when_hit();
		}
	}

	void Switch_brick_color_when_hit() {
		if ((timesHit == 1 && maxHits == 3)) {
			b_sprite_renderer.color = Color.green;
		}
		else if((timesHit == 2 && maxHits == 3) || (timesHit == 1 && maxHits == 2)) {
			b_sprite_renderer.color = Color.yellow;
		}
	}

}

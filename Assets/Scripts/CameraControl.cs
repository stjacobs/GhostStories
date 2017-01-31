using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	private float height = 5; // height from center
	private float leftWidth = 8.9f;
	private float rightWidth = 4;

	private void moveUp() {
		transform.position += new Vector3(0, 10);
	}

	private void moveDown() {
		transform.position -= new Vector3(0, 10);
	}

	private void moveLeft() {
		transform.position -= new Vector3(12.9f, 0);
	}

	private void moveRight() {
		transform.position += new Vector3(12.9f, 0);
	}

	public void updatePosition(Control player) {
		if (player.transform.position.x < transform.position.x - leftWidth) {
			print ("left");
			moveLeft();
		} else if (player.transform.position.x > transform.position.x + rightWidth) {
			moveRight ();
			print ("right");
		} else if (player.transform.position.y < transform.position.y - height) {
			moveDown ();
			print ("down");
		} else if (player.transform.position.y > transform.position.y + height) {
			moveUp ();
			print ("up");
		}
	}

	public void LateUpdate() {
	}

}

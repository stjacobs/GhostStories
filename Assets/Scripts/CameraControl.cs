using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	private const float height = 9f;
	private const float width = 12f;

	private void moveUp() {
		transform.position += new Vector3(0, height);
	}

	private void moveDown() {
		transform.position -= new Vector3(0, height);
	}

	private void moveLeft() {
		transform.position -= new Vector3(width, 0);
	}

	private void moveRight() {
		transform.position += new Vector3(width, 0);
	}

	public void move(Direction direction) {
		switch (direction) {
		case Direction.DOWN:
			moveDown ();
			break;
		case Direction.UP:
			moveUp ();
			break;
		case Direction.LEFT:
			moveLeft ();
			break;
		case Direction.RIGHT:
			moveRight ();
			break;
		}
	}

	public Vector3 getPosition() {
		return transform.position;
	}


	// TODO: Figure out how to move camera
	public void OnTriggerEnter2D(Collider2D coll) {
		print("COLL");
	}

	public float getWidth() {
		return width;
	}

	public float getHeight() {
		return height;
	}

}

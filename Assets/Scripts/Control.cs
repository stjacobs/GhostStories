using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

	public float speed;

	private float xDelta = 0;
	private float yDelta = 0;
	private CameraControl cameraControl;

	// Use this for initialization
	void Start () {
		cameraControl = GameObject.Find("Main Camera").GetComponent<CameraControl>();
		print (cameraControl);
	}

	void Update() {
		xDelta += Input.GetAxisRaw ("Horizontal");
		yDelta += Input.GetAxisRaw ("Vertical");
	}

	void FixedUpdate () {
		transform.position = transform.position + new Vector3 (xDelta / 10, yDelta / 10);
		xDelta = 0;
		yDelta = 0;
	}

	void OnBecameInvisible() {
		cameraControl.move (getMoveDirection());
	}

	private Direction getMoveDirection() {
		Vector3 cameraPos = cameraControl.getPosition ();
		Vector3 playerPos = transform.position;
		if (playerPos.x < cameraPos.x - (cameraControl.getWidth() / 2)) {
			return Direction.LEFT;
		}
		if (playerPos.x > cameraPos.x + (cameraControl.getWidth() / 2)) {
			return Direction.RIGHT;
		}
		if (playerPos.y < cameraPos.y - (cameraControl.getHeight() / 2)) {
			return Direction.DOWN;
		}
		if (playerPos.y > cameraPos.y - (cameraControl.getHeight() / 2)) {
			return Direction.UP;
		}
		return Direction.NONE;
	}

}

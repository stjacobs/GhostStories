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
		cameraControl = GameObject.Find("Main Camera").GetComponent<CameraControl> ();
	}

	void Update() {
		xDelta += Input.GetAxisRaw ("Horizontal");
		yDelta += Input.GetAxisRaw ("Vertical");
	}

	void FixedUpdate () {
		transform.position = transform.position + new Vector3 (xDelta / 10, yDelta / 10);
		xDelta = 0;
		yDelta = 0;
		cameraControl.updatePosition (this);
	}

}

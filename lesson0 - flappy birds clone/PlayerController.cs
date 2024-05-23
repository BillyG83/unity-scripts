using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	// public speed variable
	public float speed = 20.0f;
	// the speed at which the player can transition left / right
	public float turnSpeed = 50.0f;

	// from controller inputs, ranges from -1 to 0 to +1
	public float horizontalInput = 0.0f;
	public float forwardInput = 0.0f;

	// Start is called before the first frame update
	void Start() {}

	// Update is called once per frame
	void Update() {
		// get value of keyboard inputs
		horizontalInput = Input.GetAxis("Horizontal");
		forwardInput = Input.GetAxis("Vertical");

		// apply inout values and speeds to create controller based movement
		transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
		transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
	}
}

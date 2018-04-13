using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform player;
	private Vector3 offset;

	void Start () {
		//Calculate and store the offset value by getting the distance between the player's position and camera's position.
		offset = transform.position - player.transform.position;
	}

	// Update is called once per frame
	void FixedUpdate () {
		transform.position = player.transform.position + offset;
		Debug.Log (transform.position);
	}
}

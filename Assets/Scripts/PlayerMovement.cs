using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public int m_speed = 10;
	public int m_force = 100;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().velocity = Vector3.forward * m_speed;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetKeyDown ("a")) {
			Debug.Log ("A");
			GetComponent<Rigidbody>().AddForce(Vector3.left * m_force);
		}

		if (Input.GetKeyDown ("d")) {
			Debug.Log ("D");
			GetComponent<Rigidbody> ().AddForce (Vector3.right * m_force);
		}
		
	}
}

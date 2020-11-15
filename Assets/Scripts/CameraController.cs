using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset; // assign value between camera and the game object

	// Use this for initialization
	void Start () {

		offset = transform.position - player.transform.position; //cal distance between camera and the object
		
	}
	
	// Lateupdate method call after update each frame
	void LateUpdate () {

		transform.position = player.transform.position + offset;
		
	}
}

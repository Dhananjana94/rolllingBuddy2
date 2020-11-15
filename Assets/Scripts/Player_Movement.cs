// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

	public Rigidbody rb; 
	public float ForwadForced = 500;
	public float SideForced = 1000;

	// Use this for initialization
	void Start () {

		
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		rb.AddForce(0,0,ForwadForced * Time.deltaTime); // in this section we will add force speed to object

		// add movement key to the obect

		if (Input.GetKey("d"))
		{
			rb.AddForce(SideForced * Time.deltaTime,0,0,ForceMode.VelocityChange);
		}

		if (Input.GetKey("a"))
		{
			rb.AddForce(-SideForced * Time.deltaTime,0,0,ForceMode.VelocityChange);
		}

		if (rb.position.y < 0f)
		{
			FindObjectOfType<GameManager>().GameOver();
		}

	}
}

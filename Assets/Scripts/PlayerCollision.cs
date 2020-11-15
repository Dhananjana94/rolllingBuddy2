using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	//check whether player collide with some barrier

	private void OnCollisionEnter(Collision collisionInfo){

		if (collisionInfo.collider.tag == "obstacle")
		{
			FindObjectOfType<GameManager>().GameOver();
			FindObjectOfType<Player_Movement>().enabled = false;
		}

	}
}

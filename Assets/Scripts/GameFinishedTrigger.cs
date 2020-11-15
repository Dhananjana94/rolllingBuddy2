using UnityEngine;

public class GameFinishedTrigger : MonoBehaviour {

	private void OnTriggerEnter(Collider collisionInfo) {

		if (collisionInfo.tag == ("Player")) // when only player move on to end trigger
		{
			FindObjectOfType<GameManager>().LevelComplete(); 
			FindObjectOfType<Player_Movement>().enabled = false;
		}
		 
	}
}

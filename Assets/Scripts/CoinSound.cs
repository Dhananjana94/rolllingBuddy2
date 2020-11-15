using UnityEngine;

public class CoinSound : MonoBehaviour {

	public AudioSource coinSound;

	public void PlayCoinSound(){

		coinSound.Play(); // play sound when player colide with barrer

	}
}
 
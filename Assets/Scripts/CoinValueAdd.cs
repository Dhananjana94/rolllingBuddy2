using UnityEngine;
using UnityEngine.UI;

public class CoinValueAdd : MonoBehaviour {

	// public GameObject scoreText;
	// public GameObject soundManager;

	private void OnTriggerEnter(Collider other) {
		
		 if (other.CompareTag("Player"))
		{
			// scoreText.GetComponent<Score>().CoinValue += 100;
			// soundManager.GetComponent<CoinSound>().PlayCoinSound(); //call meyhod inside coinSound

			FindObjectOfType<Text>().GetComponent<Score>().CoinValue += 10f;
			FindObjectOfType<CoinSound>().PlayCoinSound();
			Destroy(gameObject);
		}

	}
}

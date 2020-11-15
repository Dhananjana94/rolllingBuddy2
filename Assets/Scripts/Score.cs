using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform playerTransform;
	public Text ScoreText;
	public float CoinValue; //add value to the coin
	
	// Update is called once per frame
	void Update () {
		
		ScoreText.text = (playerTransform.position.z+CoinValue).ToString("0"); //using 0 float number convert into real numbers

	}
}

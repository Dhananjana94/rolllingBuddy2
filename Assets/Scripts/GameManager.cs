using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

bool gameEnded = false;
public GameObject LevelCompleteUI;

public GameObject gameOverPanel;


	public void LevelComplete(){

	//Debug.Log("You Won Level");
	LevelCompleteUI.SetActive(true);
}

//create game over function

public void GameOver(){

	if(gameEnded == false)
	{
		gameEnded = true;
			//Debug.Log("Game Over");
			//Invoke("Restart",2f);
			
		gameOverPanel.SetActive(true);
        }
	
}

public void MainMenu() {

		SceneManager.LoadScene("Menu");
	
	}
public void Restart(){

	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}

}

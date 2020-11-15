using UnityEngine;
using UnityEngine.SceneManagement;


public class GameStart : MonoBehaviour {

public void StartGame(){

	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

}
}

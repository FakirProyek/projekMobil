using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Menu : MonoBehaviour {

	void Start () {
		BallController.gameOver = false;
		GroundController.numCreatePlatform = 0.02f;
		BallController.CoinCount = 0;
	
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			SceneManager.LoadScene("Main");
		}
		if (Input.touchCount > 0) {
            SceneManager.LoadScene("Main");
		}
	
	}
}

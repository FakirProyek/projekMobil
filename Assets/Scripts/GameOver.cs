using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameOver : MonoBehaviour {
	public Text score;
	// Use this fo
	void Start () {
		BallController.gameOver = true;
		GroundController.numGroundScene = 0;
	
	}
	
	void Update () {
		score.text = BallController.CoinCount.ToString ();
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Application.LoadLevel("Menu");
		}

		if (Input.touchCount > 0) {
			Application.LoadLevel ("Menu");
		}
	
	}
}

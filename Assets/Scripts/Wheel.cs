using UnityEngine;
using System.Collections;

public class Wheel : MonoBehaviour {
	public bool dir = false;

	void Start () {
	
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)&& BallController.gameOver == !true)
		{
			dir = !dir;
		}
		if(dir == false)
		{
			transform.eulerAngles = new Vector3(0,0,0);
		}
		if(dir == true)
		{
			transform.eulerAngles = new Vector3(0,90,0);
		}
	
	}
}

using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public Transform Ball;
	private Vector3 Dist;
	public float lerpVal;
	private Vector3 pos,posTarget;

	void Start () {
		Dist = Ball.position - transform.position;
	
	}

	void LateUpdate()
	{
		if(!BallController.gameOver)
		{
			Camera ();
		}

	}
	void Camera()
	{
		pos = transform.position;
		posTarget = Ball.position - Dist;
		pos = Vector3.Lerp (pos, posTarget, lerpVal);
		transform.position = pos;
	}
}

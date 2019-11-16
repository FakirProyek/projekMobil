using UnityEngine;
using System.Collections;

public class GroundController : MonoBehaviour {
	public GameObject ground, coin;
	public float sizeXZ;
	public Vector3 lastPos;
	public int groundLimit;
	public static int numGroundScene;
	public static float numCreatePlatform = 0.02f;
	public static bool canCreate = true;

	void Start () 
	{
		numGroundScene = 0;
		lastPos = ground.transform.position;
		sizeXZ = ground.transform.localScale.x;
		BallController.gameOver = false;
		canCreate = true;


	}
	void Update (){
		if (canCreate == true) {
		InvokeRepeating ("Create", 0.1f, 0.1f);
		
		}
		if (canCreate == false) {
		CancelInvoke();
		}
	
	
	
	}
	

	void CreateX()
	{
		Vector3 tempPos = lastPos;
		tempPos.x += sizeXZ;
		lastPos = tempPos;
		Instantiate (ground, tempPos, Quaternion.identity);

		int rand = Random.Range (0, 5);
		if(rand <=1)
		{
			Instantiate(coin,new Vector3(tempPos.x,tempPos.y +0.2f,tempPos.z),coin.transform.rotation);
		}

	}
	void CreateZ()
	{
		Vector3 tempPos = lastPos;
		tempPos.z += sizeXZ;
		lastPos = tempPos;
		Instantiate (ground, tempPos, Quaternion.identity);

		int rand = Random.Range (0, 5);
		if(rand <=1)
		{
			Instantiate(coin,new Vector3(tempPos.x,tempPos.y+0.2f,tempPos.z),coin.transform.rotation);
		}
	}
	void CreateXZ()
	{
		int temp = Random.Range (0, 10);

		if(numGroundScene < groundLimit)
		{
			if(temp < 5)
			{
				CreateX();
				numGroundScene++;
			}
		else if(temp >= 5)
			{
				CreateZ();
				numGroundScene++;

			}
		
		}
	}
	void Create()
	{
		if (BallController.gameOver == false) {
			CreateXZ();
		}
	}
	

}

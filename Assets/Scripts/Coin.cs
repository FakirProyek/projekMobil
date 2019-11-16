using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Coin : MonoBehaviour {
	public static int coins;
    public static int health;
	public Text coinscount;
    public Text healthcount;
	void Start () {
	
	}
	
	void Update () {
		transform.Rotate (new Vector3 (50*Time.deltaTime,0,0));
	}
}

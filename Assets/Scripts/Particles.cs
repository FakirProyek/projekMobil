using UnityEngine;
using System.Collections;

public class Particles : MonoBehaviour {
	public bool dir = false;
    BallController other;
	
	
	 public void Update () {
		if(Input.GetKeyDown(KeyCode.Space) && BallController.gameOver == !true)
		{
			dir = !dir;
		}
		if(dir == false)
		{
               
			transform.eulerAngles = new Vector3(0,270,0);
            //Debug.Log("Z dir");
		}
		if(dir == true)
		{
            
			transform.eulerAngles = new Vector3(0,160,0);
            //Debug.Log("X dir");
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && BallController.gameOver == !true)
        {
            dir = !dir;
        }
        if (dir == false)
        {

            transform.eulerAngles = new Vector3(0, 270, 0);
        }
        if (dir == true)
        {

            transform.eulerAngles = new Vector3(0, 160, 0);
        }
    }

    
}
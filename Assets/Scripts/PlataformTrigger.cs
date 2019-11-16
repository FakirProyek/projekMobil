using UnityEngine;
using System.Collections;

public class PlataformTrigger : MonoBehaviour {
	public Rigidbody rb;

	void Start(){
		rb = GetComponent<Rigidbody> ();
	}

	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			rb.useGravity = true;
			Destroy(gameObject,0.5f);
			GroundController.numGroundScene--;
            //Debug.Log("hancur");
		}
	}
}

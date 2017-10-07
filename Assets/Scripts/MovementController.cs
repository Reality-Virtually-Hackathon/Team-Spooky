using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {
	
	public GameObject cameraRig; 

	private Rigidbody rb; 

	void Start () {
		rb = cameraRig.GetComponent<Rigidbody>(); 
	}

	void Update () {
		rb.AddRelativeForce(Vector3.forward * 50); 
		Debug.Log(cameraRig.transform.position);
	}
}

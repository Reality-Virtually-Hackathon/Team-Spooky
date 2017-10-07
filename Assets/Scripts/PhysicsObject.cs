using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsObject : MonoBehaviour {
    private Rigidbody rb;
    public int torqueForce;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Interact()
    {
        rb.AddTorque(transform.up * torqueForce * Time.deltaTime);
    }

}

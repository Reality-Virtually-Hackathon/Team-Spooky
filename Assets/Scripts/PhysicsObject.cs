using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsObject : MonoBehaviour {
    private Rigidbody rb;
    public int torqueForce;
    public GameObject scareObj;
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
        scareObj.GetComponent<ScareObject>().lifetime = 6;
        scareObj.active = true;
    }
    public void OnTriggerEnter(Collider col)
    { if (col.gameObject.tag == "Hand") { if (col.gameObject.GetComponent<Hand>().spectral == true) { Interact(); } } }
}

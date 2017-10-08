using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundry : MonoBehaviour {
    public GameObject oppositeWall;
    public GameObject center;
    public bool finalBoundry;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider col)
    { if (col.gameObject.tag == "Player") {
            Debug.Log("border");
            col.transform.position = col.transform.position - (transform.position - oppositeWall.transform.position); } }

    public void OnTriggerExit(Collider other)
    {
        if (finalBoundry == true && other.gameObject.tag == "Player") { other.transform.position = center.transform.position; }
    }
}

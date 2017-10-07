using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kid : MonoBehaviour {
    public Gamebject eyes;
    public int scareMeter;
    public bool isScared;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void LineOfSightCheck(GameObject currentScaryObject)
    {
        RaycastHit hit;

        if (Physics.Raycast(eyes.transform.position, transform.forward, out hit, 5.0f) && hit.transform.gameObject == currentScaryObject)
        {
            hit.transform.gameObject.SendMessage("Interact", this.gameObject);

        }
    }
}

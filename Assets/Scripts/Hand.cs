using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {
    public bool spectral;
    public bool physical;
    public bool left;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (left == true)
        {
            if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger))
                spectral = true;
            else { spectral = false; }
            if (OVRInput.Get(OVRInput.RawButton.RHandTrigger))
                GetComponent<Collider>().isTrigger = false;
            else { GetComponent<Collider>().isTrigger =  true; }

        }
        else {
            if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
                spectral = true;
            else { spectral = false; }
            if (OVRInput.Get(OVRInput.RawButton.RHandTrigger))
                GetComponent<Collider>().isTrigger = false;
            else { GetComponent<Collider>().isTrigger = true; }

        }
    }
}

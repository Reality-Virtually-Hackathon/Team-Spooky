using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmTrapObject : MonoBehaviour {
    public GameObject myTrapToArm;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Interact()
    {
        myTrapToArm.GetComponent<ProximityObject>().Armed();
       
    }
}

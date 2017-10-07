using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    public GameObject doorHinge;
    public bool open;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Interact() {
        HingeJoint hinge = doorHinge.GetComponent<HingeJoint>();
        JointSpring hingeSpring = hinge.spring;
        if (open == true) { open = false;
            
            hingeSpring.targetPosition = 0;
        }
        else { open = true; hingeSpring.targetPosition = 70; }
        hinge.spring = hingeSpring;
    }
}

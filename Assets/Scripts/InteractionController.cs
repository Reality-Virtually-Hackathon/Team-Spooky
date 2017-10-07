using System;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController: MonoBehaviour
{

	public void Interact() {
		RaycastHit hit;

		if (Physics.Raycast(transform.position, transform.forward, out hit, 5.0f) && hit.transform.tag == "Interactable")
		{
			hit.transform.gameObject.SendMessage("Interact", this.gameObject);

		}
	}

	public void Update () {
		if (OVRInput.Get (OVRInput.RawButton.LIndexTrigger) || OVRInput.Get (OVRInput.RawButton.RIndexTrigger)) {
			Debug.Log ("You're pressing a button!"); 
			Interact (); 
		}
	}
}


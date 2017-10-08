using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScareObject : MonoBehaviour {
    public int scareValue;
    public GameObject parentObject;
    public float lifetime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (lifetime > 0) { lifetime -= Time.deltaTime; }
        if (lifetime <= 0) { this.gameObject.active = false; }
	}

    public void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Kid")
        {
            col.GetComponent<Kid>().LineOfSightCheck(parentObject, scareValue);
        }
    }
}

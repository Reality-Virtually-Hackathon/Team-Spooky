using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScareObject : MonoBehaviour {
    public int scareValue;
    public GameObject lastScareObject; //cant be scared by the same thing twice in a row
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Kid")
        {
            col.GetComponent<Kid>().LineOfSightCheck(this.gameObject);
        }
    }
}

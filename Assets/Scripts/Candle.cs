﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour {
    public bool on;
    public GameObject flame;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider col)
    {
<<<<<<< HEAD
		if (col.gameObject.tag == "Player" && on == true) { flame.active = false; GetComponent<SphereCollider>().radius = 0.1f; AkSoundEngine.PostEvent ("Candle", gameObject); }
=======
        if (col.gameObject.tag == "Player" && on == true) { flame.active = false; GetComponent<SphereCollider>().radius = 0.1f; }
>>>>>>> bb4a869f58355f7d048ab4e8b04fece70b09b5f5
        if (col.gameObject.tag == "Kid" && on == false) { flame.active = true; GetComponent<SphereCollider>().radius = 0.03f; }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityObject : MonoBehaviour {
    public bool armed;
    public float totalCountdown;
    public float countdown;

    private Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (armed == true)
        { countdown -= Time.deltaTime; }
        if (countdown <= 0) { armed = false;  }
	}

    public void OnTriggerEnter(Collider col)
    { if (col.gameObject.tag == "Kid" && armed == true) { ActivateScare(); } }


    public void ActivateScare()
    {
        armed = false;
        anim.Play("Pop");
  
    }
    public void Armed()
    {
        countdown = totalCountdown;
        armed = true;
        
    }
}

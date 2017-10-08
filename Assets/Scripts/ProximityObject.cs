using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityObject : MonoBehaviour {
    public bool armed;
    public float totalCountdown;
    public float countdown;
    public bool staticScare;
    public GameObject scareObj;
    private Animator anim;
    public string myAnimation;
    public string myScareSound;
    public string myArmSound;
    // Use this for initialization
    void Start () {
        if (staticScare == false)
        {
            anim = GetComponent<Animator>();
        }
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
        if (staticScare == false)
        {
            armed = false;
            anim.Play(myAnimation);
			AkSoundEngine.PostEvent (myScareSound, gameObject);
        }
        else
        {
            scareObj.GetComponent<ScareObject>().lifetime = 6;
            scareObj.active = true;
        }
  
    }
    public void Armed()
    {
        countdown = totalCountdown;
        armed = true;
		AkSoundEngine.PostEvent (myArmSound, gameObject);
        
    }
}

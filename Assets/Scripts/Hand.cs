<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {
    public bool spectral;
    public bool physical;
    public GameObject spectralIndicator;
    public GameObject physicalIndicator;
    public bool left;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (left == true)
        {
            if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger))
            {
                spectral = true;
                spectralIndicator.active = true;
                physicalIndicator.active = false;
            }
            else { spectral = false; spectralIndicator.active = false; }
            if (OVRInput.Get(OVRInput.RawButton.LHandTrigger))
            {
                GetComponent<Collider>().isTrigger = false; physicalIndicator.active = true;
            }
            else { GetComponent<Collider>().isTrigger = true; physicalIndicator.active = false; }
        }


        else
        {
            if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
            {
                spectral = true;
                physicalIndicator.active = false;
                spectralIndicator.active = true;
            }

            else { spectral = false; spectralIndicator.active = false; }

            if (OVRInput.Get(OVRInput.RawButton.RHandTrigger))
            { GetComponent<Collider>().isTrigger = false; physicalIndicator.active = true; }
            else { GetComponent<Collider>().isTrigger = true; physicalIndicator.active = false; }

        }
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {
    public bool spectral;
    public bool physical;
<<<<<<< HEAD
    public GameObject spectralIndicator;
    public GameObject physicalIndicator;
    public bool left;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (left == true)
        {
            if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger))
            {
                spectral = true;
                spectralIndicator.active = true;
                physicalIndicator.active = false;
            }
            else { spectral = false; spectralIndicator.active = true; }
            if (OVRInput.Get(OVRInput.RawButton.RHandTrigger))
            {
                GetComponent<Collider>().isTrigger = false; physicalIndicator.active = true;
            }
            else { GetComponent<Collider>().isTrigger = true; physicalIndicator.active = false; }
        }


        else
        {
            if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
            {
                spectral = true;
                physicalIndicator.active = false;
                spectralIndicator.active = true;
            }

            else { spectral = false; spectralIndicator.active = false; }

            if (OVRInput.Get(OVRInput.RawButton.RHandTrigger))
            { GetComponent<Collider>().isTrigger = false; physicalIndicator.active = true; }
            else { GetComponent<Collider>().isTrigger = true; physicalIndicator.active = false; }

        }
=======
    public GameObject spectralIndicator;
    public GameObject physicalIndicator;
    public bool left;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (left == true)
        {
            if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger))
            {
                spectral = true;
                spectralIndicator.active = true;
                physicalIndicator.active = false;
            }
            else { spectral = false; spectralIndicator.active = true; }
            if (OVRInput.Get(OVRInput.RawButton.RHandTrigger))
            {
                GetComponent<Collider>().isTrigger = false; physicalIndicator.active = true;
            }
            else { GetComponent<Collider>().isTrigger = true; physicalIndicator.active = false; }
        }


        else
        {
            if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
            {
                spectral = true;
                physicalIndicator.active = false;
                spectralIndicator.active = true;
            }

            else { spectral = false; spectralIndicator.active = false; }

            if (OVRInput.Get(OVRInput.RawButton.RHandTrigger))
            { GetComponent<Collider>().isTrigger = false; physicalIndicator.active = true; }
            else { GetComponent<Collider>().isTrigger = true; physicalIndicator.active = false; }

        }
>>>>>>> 037ece321dd729b057afc3d6223a342aa14e8428
    }
}
>>>>>>> bb4a869f58355f7d048ab4e8b04fece70b09b5f5

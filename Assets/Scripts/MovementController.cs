﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {
	
	public GameObject cameraRig; 
	public float movementSpeed;
	public static float micLoudness; 
	private int sample = 128; 
	private Rigidbody rb; 
	private AudioClip clip; 

	void Start () {
		rb = GetComponent<Rigidbody>(); 
		clip = Microphone.Start (null, true, 999, 44100); 
	}

	void FixedUpdate() {
		micLoudness = LevelMax (); 
		Debug.Log (micLoudness); 
		if (micLoudness > 0.001) {
<<<<<<< HEAD
			Debug.Log (micLoudness); 
			transform.Translate(cameraRig.transform.forward * Time.deltaTime);
=======
			rb.AddForce (cameraRig.transform.forward * movementSpeed); 
>>>>>>> parent of 2266c00... More movement changes
		}
	}
		
	float LevelMax() {
		float levelMax = 0; 
		float[] waveData = new float[sample];
		int micPos = Microphone.GetPosition (null) - (sample + 1); 
		if (micPos < 0)
			return 0; 
		clip.GetData (waveData, micPos);
		for (int i = 0; i < sample; i++) {
			float wavePeak = waveData [i] * waveData [i];
			if (levelMax < wavePeak) {
				levelMax = wavePeak; 
			}
		}
		return levelMax; 
	}

}

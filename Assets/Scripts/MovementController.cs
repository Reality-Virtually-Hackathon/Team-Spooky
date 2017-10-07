using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {
	
	public GameObject cameraRig; 
	public float movementSpeed;
	public static float micLoudness; 
	private int sample = 128; 
	private AudioClip clip; 

	void Start () {
		clip = Microphone.Start (null, true, 999, 44100); 
	}

	void FixedUpdate() {
<<<<<<< HEAD
		micLoudness = LevelMax (); 
		if (micLoudness > 0.001) {
			Debug.Log (micLoudness); 
			transform.Translate(cameraRig.transform.forward, Time.deltaTime);
		}
=======

		micLoudness = LevelMax ();
        if (micLoudness > 0.001) {
            //	rb.AddForce (cameraRig.transform.forward * movementSpeed); 
            transform.position = Vector3.MoveTowards(transform.position, cameraRig.transform.position, movementSpeed * Time.deltaTime);
        }


>>>>>>> a6fe35f0840f07422bf3d7cbb648251bf4b53755
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

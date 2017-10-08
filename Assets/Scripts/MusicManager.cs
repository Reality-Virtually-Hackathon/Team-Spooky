using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

	public static GameObject wg;
	public GameObject _wg;
	// Use this for initialization
	void Start () {
		wg = _wg;
		StartMX ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("s")) {
			MusicScared ();
		}

		if (Input.GetKeyDown ("a")) {
			MusicNotScared ();
		}
	}


	public static void StartMX(){
		AkSoundEngine.PostEvent("PlayMX", wg);
	}

	public static void MusicScared(){
		AkSoundEngine.PostEvent ("Scared", wg);
	}

	public static void MusicNotScared(){
		AkSoundEngine.PostEvent ("NotScared", wg);
	}

	public static void MovingMusic(){
		AkSoundEngine.PostEvent ("Moving", wg);
	}

	public static void NotMovingMusic(){
		AkSoundEngine.PostEvent ("NotMoving", wg);
	}


}

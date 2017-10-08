using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KidTracker : MonoBehaviour {
    public int kidsRemaining;
    public int totalKids;
    public Text kidCount;
	// Use this for initialization
	void Start () {
        kidCount.text = kidsRemaining.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void KidScaredAway()
    {
        kidsRemaining--;
        kidCount.text = kidsRemaining.ToString();
		if (kidsRemaining <= 4) {
			MusicManager.MusicScared_Low ();
		}

		if (kidsRemaining <= 2) {
			MusicManager.MusicScared_High ();
		}
        if (kidsRemaining <= 0) { YouWin(); }
    }
    public void YouWin() { }
}

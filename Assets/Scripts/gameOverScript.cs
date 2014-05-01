using UnityEngine;
using System.Collections;

public class gameOverScript : MonoBehaviour {

	int score = 0;
	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt ("Score");
	}
	
	// Update is called once per frame
	void OnGUI () {
		GUI.Label (new Rect (Screen.width / 2 - 40, 50, 80, 30), "GAME OVER");
		GUI.Label (new Rect (Screen.width / 2 - 40, 300, 80, 30), "Score : " + score);
		if (GUI.Button (new Rect (Screen.width / 2 - 40, 350, 60, 30), "Retry ?")) {
			Application.LoadLevel(0);
		}

	}
}

using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {

	hudScript hud;

	void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "Player") {
			hud = GameObject.Find("Main Camera").GetComponent<hudScript>();
			hud.Score(10);
			Destroy (this.gameObject);
		}
	}
}

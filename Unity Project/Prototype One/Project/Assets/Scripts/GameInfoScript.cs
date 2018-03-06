using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInfoScript : MonoBehaviour {

	Text thisText;

	void Awake() {
		thisText = GetComponent<Text>();
	}
	void Update () {
		thisText.text = "Round " + GameManager.currentRound + "\n";
		thisText.text += "Track by Artist";
	}
}

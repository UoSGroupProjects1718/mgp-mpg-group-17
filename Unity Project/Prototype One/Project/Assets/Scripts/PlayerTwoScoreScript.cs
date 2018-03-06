using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTwoScoreScript : MonoBehaviour {

	Text thisText;

	void Awake() {
		thisText = GetComponent<Text>();
	}
	void Update () {
		thisText.text = "" + GameManager.playerTwoScore;
	}
}

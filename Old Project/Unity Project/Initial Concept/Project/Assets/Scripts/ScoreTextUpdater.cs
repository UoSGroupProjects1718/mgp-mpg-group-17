using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextUpdater : MonoBehaviour {

	public ScoreScript ScoreManager;

	void Start() {
		//get the score manager
		ScoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreScript>();
	}
	void Update () {
		//Update the score text to show the score
		GetComponent<Text>().text = "" + ScoreManager.score;
	}
}

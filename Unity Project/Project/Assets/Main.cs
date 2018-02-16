using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
	public Canvas theCanvas;
	public GameObject theBackground;

	void Update () {
		transform.Translate(0f, 0.04f, 0f); //move the camera up
		theCanvas.transform.Translate(0f, 0.04f, 0f); //move the ui up
		theBackground.transform.Translate(0f, 0.04f, 0f);
	}
}

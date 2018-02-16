using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCollideScript : MonoBehaviour {

	public ScoreScript ScoreManager;

	void Start() {
		//get the score manager
		ScoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreScript>();
	}

	//if something is colliding with this
	void OnTriggerStay2D (Collider2D collisionInfo){
		//if the mouse button is being pressed
         if(Input.GetMouseButtonDown(0)) {
			ScoreManager.score += 10; //increase the score by 10
			Destroy(collisionInfo.gameObject); //delete the music note
		 }
     }

}

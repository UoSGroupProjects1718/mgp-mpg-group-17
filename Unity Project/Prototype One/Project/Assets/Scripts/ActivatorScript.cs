using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ActivatorScript : MonoBehaviour {

	bool active = false;
	GameObject note;

	void OnMouseDown() {
		if(!EventSystem.current.IsPointerOverGameObject() && active) {
			Destroy(note);
			GameManager.playerOneScore += 15;
		}
	}
	void OnTriggerEnter2D(Collider2D other) {
		active = true;
		if(other.gameObject.tag == "PhysicsNote")
			note = other.gameObject;
	}

	void OnTriggerExit2D(Collider2D other) {
		active = false;
	}
	
}

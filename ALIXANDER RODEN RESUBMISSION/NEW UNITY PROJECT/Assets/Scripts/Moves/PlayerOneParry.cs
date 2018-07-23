using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOneParry : MonoBehaviour {
	public Game game;

	void OnMouseDown() {
		game.controller.playerTwoCombatLog.GetComponent<Text>().text = "Parry";
		game.parrySrc.Play ();
		game.turn = false;
	}

}

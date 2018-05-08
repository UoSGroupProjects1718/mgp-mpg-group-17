using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTwoParry : MonoBehaviour {
	public Game game;

	void OnMouseDown() {
		game.controller.playerOneCombatLog.GetComponent<Text>().text = "Parry";
		game.turn = false;
	}

}

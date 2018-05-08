using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTwoSpell : MonoBehaviour {
	public Game game;

	void OnMouseDown() {
		PlayerOne.health -= 25;
		game.controller.playerOneCombatLog.GetComponent<Text>().text = "Hit with magic spell causing 25 damage";
		game.turn = true;
	}

}

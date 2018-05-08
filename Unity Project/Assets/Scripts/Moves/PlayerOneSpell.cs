using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOneSpell : MonoBehaviour {
	public Game game;

	void OnMouseDown() {
		PlayerTwo.health -= 25;
		game.controller.playerTwoCombatLog.GetComponent<Text>().text = "Hit with magic spell causing 25 damage";
		game.turn = false;
	}

}

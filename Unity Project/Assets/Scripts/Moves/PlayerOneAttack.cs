using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOneAttack : MonoBehaviour {
	public Game game;

	void OnMouseDown() {
		PlayerTwo.health -= 10;
		game.controller.playerTwoCombatLog.GetComponent<Text>().text = "Hit with sword causing 10 damage";
		game.turn = false;
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTwoAttack : MonoBehaviour {
	public Game game;

	void OnMouseDown() {
		PlayerOne.health -= 10;
		game.controller.playerOneCombatLog.GetComponent<Text>().text = "Hit with sword causing 10 damage";
		game.turn = true;
	}

}

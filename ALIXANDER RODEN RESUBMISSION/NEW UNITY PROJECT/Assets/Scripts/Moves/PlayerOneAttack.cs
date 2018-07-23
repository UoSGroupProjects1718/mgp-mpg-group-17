using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOneAttack : MonoBehaviour {
	public Game game;

	void OnMouseDown() {
		if (PlayerOne.attackCooldown <= 0) {
			PlayerTwo.health -= Random.Range (0, 35);
			game.attackSrc.Play ();
			PlayerOne.attackCooldown = Random.Range (0, 30);
			game.controller.playerOneCombatLog.GetComponent<Text>().text = "Hit other player!";
			game.turn = false;
		} else {
			game.controller.playerOneCombatLog.GetComponent<Text> ().text = "Can't use that move! " + PlayerOne.attackCooldown + " remaining cooldown";
		}
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTwoAttack : MonoBehaviour {
	public Game game;

	void OnMouseDown() {
		if (PlayerTwo.attackCooldown <= 0) {
			PlayerOne.health -= Random.Range (0, 35);
			game.attackSrc.Play ();
			PlayerTwo.attackCooldown = Random.Range (0, 30);
			game.controller.playerTwoCombatLog.GetComponent<Text>().text = "Hit other player!";
			game.turn = true;
		} else {
			game.controller.playerTwoCombatLog.GetComponent<Text> ().text = "Can't use that move! " + PlayerOne.attackCooldown + " remaining cooldown";
		}
	}

}

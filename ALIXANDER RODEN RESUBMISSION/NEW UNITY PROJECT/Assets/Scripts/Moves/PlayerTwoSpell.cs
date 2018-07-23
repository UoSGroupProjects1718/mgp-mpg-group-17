using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTwoSpell : MonoBehaviour {
	public Game game;

	void OnMouseDown() {
		if (PlayerTwo.spellCooldown <= 0) {
			PlayerOne.health -= Random.Range (0, 55);
			game.spellSrc.Play ();
			PlayerTwo.spellCooldown = Random.Range (0, 30);
			game.controller.playerTwoCombatLog.GetComponent<Text>().text = "Hit other player with spell!";
			StartCoroutine(game.controller.show_spell_p1 ());
			game.turn = true;
		} else {
			game.controller.playerTwoCombatLog.GetComponent<Text> ().text = "Can't use that move! " + PlayerOne.spellCooldown + " remaining cooldown";
		}
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOneSpell : MonoBehaviour {
	public Game game;

	void OnMouseDown() {
		if (PlayerOne.spellCooldown <= 0) {
			PlayerTwo.health -= Random.Range (0, 55);
			game.spellSrc.Play ();
			PlayerOne.spellCooldown = Random.Range (0, 30);
			game.controller.playerOneCombatLog.GetComponent<Text>().text = "Hit other player with spell!";
			StartCoroutine(game.controller.show_spell_p2 ());
			game.turn = false;
		} else {
			game.controller.playerOneCombatLog.GetComponent<Text> ().text = "Can't use that move! " + PlayerOne.spellCooldown + " remaining cooldown";
		}
	}

}

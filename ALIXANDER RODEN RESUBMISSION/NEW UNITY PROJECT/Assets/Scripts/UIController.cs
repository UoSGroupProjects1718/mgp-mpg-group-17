using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
	public GameObject playerOneHealth;
	public GameObject playerTwoHealth;
	public GameObject mainMenu;
	public GameObject winScreen;
	public GameObject playerOneCover;
	public GameObject playerTwoCover;
	public GameObject playerOneCombatLog;
	public GameObject playerTwoCombatLog;
	public GameObject winnerText;

	public GameObject joust;
	public GameObject joustScreen;
	public GameObject joustWinnerText;
	public GameObject spell_overlay_P1;
	public GameObject spell_overlay_P2;

	public IEnumerator show_spell_p1() {
		spell_overlay_P1.SetActive (true);
		yield return new WaitForSeconds (5);
		spell_overlay_P1.SetActive (false);
	}

	public IEnumerator overlay_wait_p1() {
		yield return new WaitForSeconds (10);
		playerTwoCover.SetActive (false);
		playerOneCover.SetActive (true);
	}

	public IEnumerator overlay_wait_p2() {
		yield return new WaitForSeconds (10);
		playerOneCover.SetActive (false);
		playerTwoCover.SetActive (true);
	}

	public IEnumerator show_spell_p2() {
		spell_overlay_P1.SetActive (true);
		yield return new WaitForSeconds (5);
		spell_overlay_P1.SetActive (false);
	}
}

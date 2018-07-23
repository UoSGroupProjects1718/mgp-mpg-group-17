using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {
	public InputController icontroller;
	public UIController controller;
	public bool turn;

	public AudioSource parrySrc;
	public AudioSource attackSrc;
	public AudioSource spellSrc;

	public bool joust;

	public float joust_timer = 100;

	void Start() {
		#if UNITY_STANDALONE
			Screen.SetResolution(380, 608, false);
			Screen.fullScreen = false;
		#endif
		turn = true;
		joust = false;
		controller.mainMenu.SetActive(true);
		controller.winScreen.SetActive(false);
		controller.playerOneCover.SetActive(true);
		controller.playerTwoCover.SetActive(true);
		controller.joust.SetActive (false);
		controller.spell_overlay_P1.SetActive (false);
		controller.spell_overlay_P2.SetActive (false);
		controller.playerOneHealth.GetComponent<Text>().text = PlayerOne.health + "/100";
		controller.playerTwoHealth.GetComponent<Text>().text = PlayerTwo.health + "/100";
	}

	void Update() {
		if (joust_timer > 0) {
			joust_timer -= Time.deltaTime;
		}
		if(PlayerOne.health <= 0) {
			PlayerTwo.winner = true;
			controller.winnerText.GetComponent<Text>().text = "Player Two wins! \n" + "Thankyou for playing!";
			controller.winScreen.SetActive(true);
		} else if(PlayerTwo.health <= 0) {
			PlayerOne.winner = true;
			controller.winnerText.GetComponent<Text>().text = "Player One wins! \n" + "Thankyou for playing!";
			controller.winScreen.SetActive(true);
		}
		if (PlayerOne.health < 50 || PlayerTwo.health < 50) {
			if (joust_timer == 0) {
				bool random = Random.Range (0, 2) == 1;
				if (random)
					joust = true;
				else
					joust_timer = Random.Range (0, 100);
			}
		}
		if (joust) {
			bool random = Random.Range (0, 2) == 1;
			if (random){
				PlayerOne.winner = true;
				controller.joustWinnerText.GetComponent<Text> ().text = "Joust completed! \n" + "Player One won!";
			}
			else {
				PlayerTwo.winner = true;
				controller.joustWinnerText.GetComponent<Text> ().text = "Joust completed! \n" + "Player TWo won!";
			}
			controller.joustScreen.SetActive (true);
			Application.Quit ();
		}
		controller.playerOneHealth.GetComponent<Text>().text = PlayerOne.health + "/100";
		controller.playerTwoHealth.GetComponent<Text>().text = PlayerTwo.health + "/100";
		if(turn) {
			controller.playerOneCover.SetActive(false);
			controller.playerTwoCover.SetActive(true);
		} else {
			controller.playerOneCover.SetActive(true);
			controller.playerTwoCover.SetActive(false);
		}
		if (PlayerOne.attackCooldown != 0)
			PlayerOne.attackCooldown -= Time.deltaTime;
		if (PlayerOne.spellCooldown != 0)
			PlayerOne.spellCooldown -= Time.deltaTime;
		if (PlayerTwo.attackCooldown != 0)
			PlayerTwo.attackCooldown -= Time.deltaTime;
		if (PlayerTwo.spellCooldown != 0)
			PlayerTwo.spellCooldown -= Time.deltaTime;
	}
}

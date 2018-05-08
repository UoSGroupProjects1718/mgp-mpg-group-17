using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {
	public InputController icontroller;
	public UIController controller;
	public bool turn;

	void Start() {
		turn = true;
		controller.mainMenu.SetActive(true);
		controller.winScreen.SetActive(false);
		controller.playerOneCover.SetActive(true);
		controller.playerTwoCover.SetActive(true);
		controller.playerOneHealth.GetComponent<Text>().text = PlayerOne.health + "/100";
		controller.playerTwoHealth.GetComponent<Text>().text = PlayerTwo.health + "/100";
	}

	void Update() {
		if(PlayerOne.health <= 0) {
			PlayerTwo.winner = true;
			controller.winnerText.GetComponent<Text>().text = "Player Two wins! \n" + "Thankyou for playing!";
			controller.winScreen.SetActive(true);
		} else if(PlayerTwo.health <= 0) {
			PlayerOne.winner = true;
			controller.winnerText.GetComponent<Text>().text = "Player One wins! \n" + "Thankyou for playing!";
			controller.winScreen.SetActive(true);
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
	}
}

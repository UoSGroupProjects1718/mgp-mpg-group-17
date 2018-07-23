using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputController : MonoBehaviour {
	public GameObject Player1SpellBtn;
	public GameObject Player1AttackBtn;
	public GameObject Player1ParryBtn;
	public GameObject Player2SpellBtn;
	public GameObject Player2AttackBtn;
	public GameObject Player2ParryBtn;

	public GameObject WinQuitButton;

	public GameObject StartButton;
	public GameObject QuitButton;

	public Game game;

	void Start() {
		StartButton.GetComponent<Button>().onClick.AddListener(delegate() {
			game.controller.mainMenu.SetActive(false);
		});
		QuitButton.GetComponent<Button>().onClick.AddListener(delegate() {
			Application.Quit();
		});
		WinQuitButton.GetComponent<Button>().onClick.AddListener(delegate() {
			Application.Quit();
		});
	}

}

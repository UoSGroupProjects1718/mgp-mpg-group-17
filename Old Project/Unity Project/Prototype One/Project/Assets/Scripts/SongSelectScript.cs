using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SongSelectScript : MonoBehaviour {
	public void LoadGame() {
		SceneManager.LoadScene("Scenes/MainGame");
	}
	public void BackToStart() {
		SceneManager.LoadScene("Scenes/StartScreen");
	}
}

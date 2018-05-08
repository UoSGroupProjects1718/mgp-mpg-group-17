using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenScript : MonoBehaviour {
	public void LoadSongSelectScreen() {
		SceneManager.LoadScene("Scenes/SongSelect");
	}
}

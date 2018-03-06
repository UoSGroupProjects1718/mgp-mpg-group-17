using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public List<float> notePositions = new List<float> {1, 2, 3, 3, 2, 1, 1, 2, 3, 3, 2, 2, 1, 3, 3, 2, 2, 1, 1, 2, 2, 3, 3, 1, 2, 3, 3, 2, 1, 2, 1, 2, 1, 3};

	int currentNote = 0;
	public static int playerOneScore = 0;
	public static int playerTwoScore = 0;
	public static int currentRound = 1;
	public static int currentPlayer = 1;

	public Transform noteObject;
	float xPos;
	bool timerReset = true;

	public static void increaseScore(int increaseAmmount) {
		if(currentPlayer == 1) playerOneScore += increaseAmmount;
		else if(currentPlayer == 2) playerTwoScore += increaseAmmount;
	}
	IEnumerator Spawn() {
		yield return new WaitForSeconds(1);

		if(notePositions[currentNote] == 1) {
			xPos = -1.95f;
		} else if(notePositions[currentNote] ==2) {
			xPos = 0;
		} else {
			xPos = 1.78f;
		}

		if(currentNote != notePositions.Count) {
			currentNote += 1;
			timerReset = true;
			Instantiate(noteObject, new Vector3(xPos, 2.5f, 0), noteObject.rotation);
		}
	}

	void Update() {
		if(timerReset) {
			StartCoroutine(Spawn());
			timerReset = false;
		}
	}


}

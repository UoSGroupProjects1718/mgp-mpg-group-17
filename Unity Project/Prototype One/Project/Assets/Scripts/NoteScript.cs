using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScript : MonoBehaviour {

	Rigidbody2D rigidbody;
	float speed = 1.5f;

	void Start () {
		rigidbody.velocity = new Vector2(0, -speed);
	}

	void Awake(){
		rigidbody = GetComponent<Rigidbody2D>();
		//speed = Random.Range(1, 3);
	}
	
	void Update () {
		transform.rotation = Quaternion.Euler(0, speed * Time.deltaTime, 0);
	}
}

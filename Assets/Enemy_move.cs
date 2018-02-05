using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_move : MonoBehaviour {

	public GameObject player;
	public float enemy_speed = 0.5f;

	private void Start () {
		player = GameObject.Find ("Player");
	}

	void Update () {
		moving ();
	}

	void moving(){
		
		//float x1 = player.transform.position.x - transform.position.x;
		//float z1 = player.transform.position.z - transform.position.z;

		//Vector3 player_dir = new Vector3 (Time.deltaTime*x1,0,Time.deltaTime*z1); //demenstion of element of vector

		Vector3 player_dir = player.transform.position - transform.position; // derection // demension of vector
		transform.Translate (Time.deltaTime*player_dir);

	}
}

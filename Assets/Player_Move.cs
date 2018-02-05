using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour {

	public int speed = 7;

	void Start () {
		
	}

	void Update () {
		move_func ();
	}

	void move_func(){

		float x = Input.GetAxis ("Horizontal"); 
		float z = Input.GetAxis ("Vertical");	// get data from the keyboard

		transform.Translate (x*speed*Time.deltaTime, 0, z*speed*Time.deltaTime); // move position with speed, time

	}
}

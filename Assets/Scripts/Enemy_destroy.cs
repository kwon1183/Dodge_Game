using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_destroy : MonoBehaviour {

	private float Create_Time;
	private float destory_Time=10.0f;

	void Start(){
		Create_Time = Time.time;
	}
	void Update () {
		if (Time.time - Create_Time > destory_Time) {
			Destroy (gameObject);
		}
		}
}

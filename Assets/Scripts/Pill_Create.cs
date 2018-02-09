using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pill_Create : MonoBehaviour {

	public float Last_create_time;
	public float Last_destroy_time;

	public float Create_interval=5.0f;
	public float Destroy_interval = 4.0f;
	private float Radius = 12.0f;

	public GameObject Player;
	public GameObject GoodPill_prefab;
	public GameObject BadPill_prefab;

	public void Start(){
		Last_create_time = Time.time;
		//Destroy(gameObject,Destroy_interval);
		//Last_destroy_time = Time.time;
		//Last_destroy_time = Time.time + Create_interval + Destroy_interval;
	}

	public void Update () {

		if (Time.time - Last_create_time > Create_interval) {
			create_pill ();
			//Destroy(gameObject,Destroy_interval);
			Last_create_time = Time.time;
			 // updating the last create time

			//Last_destroy_time = Time.time; 
			//Destroy (gameObject);
		}
		/*if(Time.time - Last_destroy_time > Destroy_interval) {
			Destroy (gameObject);
			Last_destroy_time = Time.time;
		}*/

	}

	public void create_pill(){

		float theta = Random.Range (0, Mathf.PI * 2);
		float ex = Mathf.Cos (theta);
		float ez = Mathf.Sin (theta);

		int pill_choice = Random.Range (0, 2); // int? float?
		var pill_position = new Vector3 (Radius*ex, 2.0f, +Radius*ez);

		if(pill_choice == 0){
		var GoodPill = Instantiate (GoodPill_prefab); // create goodpill
		GoodPill.transform.position = pill_position;
			Destroy (GoodPill, Destroy_interval);
		}

		else{
		var BadPill = Instantiate (BadPill_prefab); // create goodpill
		BadPill.transform.position = pill_position;
			Destroy (BadPill, Destroy_interval);
		}
		//Destroy (gameObject);

	}
}

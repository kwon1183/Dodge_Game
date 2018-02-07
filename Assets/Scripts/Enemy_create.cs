using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_create : MonoBehaviour {

	private float Last_create_time;
	public float Create_interval = 1.5f; // time interval of creating every 1.5f
	public float Radius = 10f; // radius from the object
	public float Last_position;

	public GameObject Player;
	public GameObject Enemy_Prefab;

	private void Update () {
		
		if (Time.time - Last_create_time > Create_interval) {
			create_enemy ();
			Last_create_time = Time.time; // updating the last create time
		}
	}

	private void create_enemy(){
		
		float theta = Random.Range (0, Mathf.PI * 2);
		float ex = Mathf.Cos (theta);
		float ez = Mathf.Sin (theta);

		var enemy = Instantiate (Enemy_Prefab); // create enemy
		var enemy_position = new Vector3 (Radius*ex, 0.5f, +Radius*ez);
		enemy.transform.position = Player.transform.position + enemy_position; // create enemies by player's position

	}
}

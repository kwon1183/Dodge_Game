using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntervalTest : MonoBehaviour {

	private float LastLogTime;

	//var v1 = Mathf.Sin (Mathf.PI / 4); //radian value
	//var v2 = Mathf.Cos (Mathf.PI / 4); //radian value
	//var v3 = Random.Range(0,2*Mathf.PI); //random spread

	private void Update () {

		
		if (Time.time - LastLogTime > 1.5f) { //present time - Lost log time is more than 1.5 sec
			Debug.LogFormat ("Hello {0}", Time.frameCount); // print
			LastLogTime = Time.time; // put the last log time to variable
		}

	}


}

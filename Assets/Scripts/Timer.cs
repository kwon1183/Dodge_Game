using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text timerText;
	private float timeCnt;

	void Update(){
		timeCnt += Time.deltaTime;

		string TimeStr;
		TimeStr = "" + timeCnt.ToString ("00.00");
		TimeStr = TimeStr.Replace (".", ":");
		timerText.text = TimeStr;
	}
/*	private int sec;
	private int min;
	private int hour;

	private float limit = 60.0f;
	private float hour_limit = 24.0f;
	public Text timerText;

	void Start () {
		timerText.text = sec.ToString ();
	}
	
	// Update is called once per frame
	void Update () {

		sec += Time.deltaTime;

		if (sec >= limit) {
			sec = 0;
			min++;
			if (min >= limit) {
				min = 0;
				hour++;
				if (hour >= hour_limit) {
					sec = 0; min = 0; hour = 0;
					}
				}
			}
		}*/
	}

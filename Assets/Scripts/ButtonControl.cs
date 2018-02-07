using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour {

	public AudioSource audioSource;

	public void OpenMainScene(){
		SceneManager.LoadScene("Game");
	}
	public void PlaySound(){
		audioSource.Play ();
	}
}

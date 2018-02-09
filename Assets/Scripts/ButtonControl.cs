using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour {
	
	//public Text addNumberButtonText;
	//public GameObject BackGroundMusic;

	public void OpenMainScene(){
		SceneManager.LoadScene("Game");
	}

	public void OpenDespScene(){
		SceneManager.LoadScene ("GameD");
	}

	public void OpenSplashScene(){
		SceneManager.LoadScene ("splash");
	}

	public void RestartMainScene(){
		SceneManager.LoadScene("Game");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}


	/*public void AddNumber(){
		var addNumber = PlayerPrefs.GetInt ("ADD_NUMBER", 0);
		addNumberButtonText.text = (addNumber + 1).ToString();
		PlayerPrefs.SetInt("ADD_NUMBER",addNumber+1);
		PlayerPrefs.Save ();
	}*/

}

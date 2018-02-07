using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButtonControl : MonoBehaviour {

	public void OpenSplashScene(){
		SceneManager.LoadScene("Splash");
	}

}

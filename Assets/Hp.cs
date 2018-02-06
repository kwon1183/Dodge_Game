using UnityEngine;
using UnityEngine.UI;

public class Hp : MonoBehaviour {

	public int hp = 10;
	public Text hpText;

	private void Start(){
		hpText.text = hp.ToString ();

	}


}

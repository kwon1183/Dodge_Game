using UnityEngine;
using UnityEngine.UI;

public class collusion : MonoBehaviour {

	public Hp playerHp;
	public Text gameover;

	private void OnTriggerEnter(Collider other){
		if (playerHp.hp == 0) {
			gameover.text = string.Format("GameOver");
			//Application.Quit();
		} // Game Over
		else
			playerHp.hp--;
		Destroy (other.gameObject); //other: component, component->gameobject deleting
		playerHp.hpText.text = string.Format("HP:{0}",playerHp.hp.ToString()); //print function
	}

}

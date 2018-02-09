using UnityEngine;
using UnityEngine.UI;

public class collusion : MonoBehaviour {

	public Hp playerHp;
	//public Text gameover;

	public GameObject Panel;

	public AudioSource enemy_sound;
	public AudioSource GoodPill_sound;
	public AudioSource BadPill_sound;

	private void Start(){
		Panel.SetActive (false);
	}

	private void OnTriggerEnter(Collider other){

		if (playerHp.hp == 0) {
			//gameover.text = string.Format ("GameOver");
			Time.timeScale = 0.0f;
			Panel.SetActive (true);
			}
		else {
			if (other.gameObject.tag == "enemy") {
				enemy_sound.Play ();
				playerHp.DamageHp (1);
				Destroy (other.gameObject); //other: component, component->gameobject deleting
			}
			if(other.gameObject.tag == "GoodPill"){
				GoodPill_sound.Play ();
				playerHp.HealHp (3);
				Destroy (other.gameObject);
			}
			if (other.gameObject.tag == "BadPill") {
				BadPill_sound.Play ();
				playerHp.DamageHp (3);
				Destroy (other.gameObject);
			}
		playerHp.hpText.text = string.Format("HP:{0}",playerHp.hp.ToString()); //print function
		}
	}
}

using UnityEngine;
using UnityEngine.UI;

public class Hp : MonoBehaviour {

	[SerializeField]
	public int hp = 10;
	public Text hpText;
	public float lastAutoHealTime;
	public float autoHealInterval=10f;


	private void Start(){
		hpText.text = hp.ToString ();
		lastAutoHealTime = Time.time;
	}

	private void Update(){
		AutoHeal ();
	}
	//player hp 관리 함수

	public void HealHp(int mount){
		hp += mount;
		UpdateHp ();
	}

	public void DamageHp(int mount){
		hp -= mount;
		UpdateHp ();
	}

	private void UpdateHp(){
		hpText.text = hp.ToString ();
	}

	private void AutoHeal(){
		if (Time.time - lastAutoHealTime > autoHealInterval) {
			HealHp (1);
			UpdateHp ();
			lastAutoHealTime = Time.time;
		}
	}
}

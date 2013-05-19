using UnityEngine;
using System.Collections;

public class GateBehavior : MonoBehaviour {
	public Transform player;
	public Transform HUD;
	Text t;// = new Text();
	
	void Start () {
		t = HUD.GetComponent<Text>();
	}
	
	void OnTriggerEnter(Collider other) {

		if (other.name == player.name) {
			PlayerControl pc = other.GetComponent<PlayerControl>();
			if(pc.hasKey1) {
				t.displaytext = "Congratulations, you won!";
				Debug.Break();
			}
			else {
				t.displaytext = "That is the gate. You need to get the key before you can enter.";
				
			}
		}
			
	}
}

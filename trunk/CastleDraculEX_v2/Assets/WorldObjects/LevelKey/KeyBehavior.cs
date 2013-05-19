using UnityEngine;
using System.Collections;



public class KeyBehavior : MonoBehaviour {
	
	public Transform player;
	public Transform gate;
	public Transform HUD;
	
	Text t;// = new Text();
	
	void Start () {
		t = HUD.GetComponent<Text>();
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.name == player.name) {
			t.displaytext = "You found the key!";
			transform.renderer.enabled = false; //turn off renderer
			PlayerControl pc = other.GetComponent<PlayerControl>();
			pc.hasKey1 = true;
		}
	
	}
}

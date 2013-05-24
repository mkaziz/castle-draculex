using UnityEngine;
using System.Collections;

public class HideTrigger : MonoBehaviour {
	
	public Transform myHUD;
	public Transform player;
	Text t;

	// Use this for initialization
	void Start () {
		t = (Text) myHUD.GetComponent("Text");
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.name == player.name) {
		t.displaytext = "It looks like those ghosts can't see me here. I don't know if they can still attack me, though.";
		}
	}

}

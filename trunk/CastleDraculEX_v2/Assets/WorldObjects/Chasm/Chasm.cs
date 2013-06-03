using UnityEngine;
using System.Collections;

public class Chasm : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) {
		Debug.Log("Chasm collision");
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		if (other.name == player.name) {
			PlayerControl pc = (PlayerControl) player.GetComponent("PlayerControl");
			pc.Health = 0;
		}
	}
}

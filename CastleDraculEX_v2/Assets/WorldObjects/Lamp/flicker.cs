using UnityEngine;
using System.Collections;

public class flicker : MonoBehaviour {

	float minOnFlickerSpeed = 0.2f;
	float maxOnFlickerSpeed = 0.5f;
	float minOffFlickerSpeed = 0.01f;
	float maxOffFlickerSpeed = 0.05f;
	
	float off_screen_distance = 30;
	
	GameObject player;
	
	void Start() {
		
		gameObject.light.enabled = true;	
		
		player = GameObject.FindWithTag("Player");
		
	}
	float dist = 0;
	bool light_off = true;
	void Update () {
		dist = Vector3.Distance(player.transform.position, gameObject.transform.position);
		if (light_off && dist < off_screen_distance) {
			StartCoroutine(initiateflicker());
		}
	}
	
	IEnumerator initiateflicker () {
		if(dist < off_screen_distance){ //optimize - if off screen, don't turn it on
			gameObject.light.enabled = true;
			float n1 = Random.Range(minOnFlickerSpeed, maxOnFlickerSpeed );
			yield return new WaitForSeconds(n1);
			gameObject.light.enabled = false;
			
			n1 = Random.Range(minOffFlickerSpeed, maxOffFlickerSpeed );
			yield return new WaitForSeconds(n1);
		}
		else {
			yield return new WaitForSeconds(1000);
			light_off = false;
		}
			StartCoroutine(initiateflicker());

	}
	
}

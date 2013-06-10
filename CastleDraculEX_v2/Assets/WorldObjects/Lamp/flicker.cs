using UnityEngine;
using System.Collections;

public class flicker : MonoBehaviour {

	float minOnFlickerSpeed = 1.0f;
	float maxOnFlickerSpeed = 1.3f;
	float minOffFlickerSpeed = 0.1f;
	float maxOffFlickerSpeed = 0.2f;
	
	float off_screen_distance = 30;
	
	GameObject player;
	
	void Start() {
		gameObject.light.enabled = true;	
		player = GameObject.FindWithTag("Player");	
		StartCoroutine(initiateflicker());
	}
	
	float dist = 0;
	bool light_on = false;
	void Update () {
		//dist = Vector3.Distance(player.transform.position, gameObject.transform.position);
		//if (!light_on && onScreen ()) {
		//	StartCoroutine(initiateflicker());
		//	light_on = true;
		//}
	}
	
	bool onScreen() {
		return dist < off_screen_distance;	
	}
	
	float wait_time;
	
	IEnumerator initiateflicker () {
		//dist = Vector3.Distance(player.transform.position, gameObject.transform.position);
		//if(dist < off_screen_distance){ //flicker if on screen
			gameObject.light.enabled = true;
			float wait_time = Random.Range(minOnFlickerSpeed, maxOnFlickerSpeed );
			yield return new WaitForSeconds(wait_time);
			
			gameObject.light.enabled = false;
			wait_time = Random.Range(minOffFlickerSpeed, maxOffFlickerSpeed );
			yield return new WaitForSeconds(wait_time);
			
			StartCoroutine(initiateflicker());
		/*}
		else { //turn it off if off screen
			gameObject.light.enabled = false;
			//new WaitForSeconds(1000); 
			light_on = false;
			yield break;
		}*/
			

	}
	
}

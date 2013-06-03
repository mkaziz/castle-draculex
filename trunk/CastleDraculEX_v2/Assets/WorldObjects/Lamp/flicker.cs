using UnityEngine;
using System.Collections;

public class flicker : MonoBehaviour {

	float minOnFlickerSpeed = 0.2f;
	float maxOnFlickerSpeed = 0.5f;
	float minOffFlickerSpeed = 0.05f;
	float maxOffFlickerSpeed = 0.1f;
	
	void Start() {
		gameObject.light.enabled = true;	
		StartCoroutine(initiateflicker());
		/*while (true) {
			gameObject.light.enabled = true;
			Debug.Log("Flickering on!");
			float n1 = Random.Range(minOnFlickerSpeed, maxOnFlickerSpeed );
			yield return new WaitForSeconds(n1);
			gameObject.light.enabled = false;
			Debug.Log("Flickering off!");
			n1 = Random.Range(minOffFlickerSpeed, maxOffFlickerSpeed );
			yield return new WaitForSeconds(n1);
		}*/
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	IEnumerator initiateflicker () {
		
		gameObject.light.enabled = true;
		//Debug.Log("Flickering on!");
		float n1 = Random.Range(minOnFlickerSpeed, maxOnFlickerSpeed );
		yield return new WaitForSeconds(n1);
		gameObject.light.enabled = false;
		//Debug.Log("Flickering off!");
		n1 = Random.Range(minOffFlickerSpeed, maxOffFlickerSpeed );
		yield return new WaitForSeconds(n1);
		StartCoroutine(initiateflicker());
	}
	
}

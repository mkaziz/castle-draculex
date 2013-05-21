using UnityEngine;
using System.Collections;

public class Follower : MonoBehaviour {
	
	public Transform leader;
	public float speed = 3;
	public bool colliding = false;
	RaycastHit hit;
	
	// Use this for initialization
	void Start () {
		transform.LookAt(leader);
	}
	
	// Update is called once per frame
	void Update () {
	
		float distance = Vector3.Distance(leader.position, transform.position);
		Component playerHidingScript = leader.gameObject.GetComponent("HidingPlayer");
		HidingPlayer phs = (HidingPlayer) playerHidingScript;
		bool hidden = phs.hidden;
		//bool hidden = false;
		
		if(distance < 7 && hidden == false) { //chasing!
		   	transform.LookAt(leader);
		   	speed = 7;
			Color mycolor = transform.renderer.material.color;
			mycolor.a = 100;
		   	transform.renderer.material.color = mycolor;
	   	}
	   	else { //not chasing
	   		transform.renderer.material.color = Color.grey;
			Color mycolor = transform.renderer.material.color;
			mycolor.a = 0;
	   		transform.renderer.material.color = mycolor;
	   		if (Random.Range(0, 100) <= 1)
	   		{
				transform.Rotate(0.0f,0.0f,Random.Range(30, 360), Space.World);
			}
			speed = 3;
	   	}
	   	
	   	if (colliding) {
   			transform.Rotate(0.0f,0.0f,Random.Range(30, 360), Space.World);
   		}
		rigidbody.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);

	}

void OnTriggerEnter(Collider other)
{
	Debug.Log("Collision Start");
	
	if (other.name == leader.name) {
		Debug.Break();
	}
	else if (other.name == "HidingPlace") {}
	else if (other.name == "Gate") {}
	else if (other.name == "LevelKey") {}
	else {
		colliding = true;
	}
	
}

void OnTriggerExit(Collider other)
{
	Debug.Log("End Collision");
	colliding = false;
}

}

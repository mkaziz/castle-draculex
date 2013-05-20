#pragma strict	


var leader : Transform; 
var speed : float = 3; // The speed of the follower 
var colliding : boolean = false;

//var collision_direction : 
 
function Start () {
	transform.LookAt(leader);
}
var hit : RaycastHit;

function FixedUpdate(){ 
	
	
		var distance = Vector3.Distance(leader.position, transform.position);
		var playerHidingScript : HidingPlayer = leader.gameObject.GetComponent("HidingPlayer");
		var hidden = playerHidingScript.hidden;
		
		if(distance < 7 && hidden === false) {
		   	transform.LookAt(leader);
		   	speed = 7;
		   	transform.renderer.material.color = Color.white;
		   	transform.renderer.material.color.a = 255;
	   	}
	   	else {
	   		transform.renderer.material.color = Color.gray;
	   		transform.renderer.material.color.a = 50;
	   		if (Random.Range(0, 100) <= 1)
	   		{
				//transform.localEulerAngles.x = Random.Range(30, 360);
				//transform.Rotate(0.0,0.0,Random.Range(30, 360));
				transform.Rotate(0.0,0.0,Random.Range(30, 360), Space.World);
			}
			speed = 3;
	   	}
	   	
	   	if (!colliding) {
   			rigidbody.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
   		}
   		else {
   			//transform.localEulerAngles.x = Random.Range(30, 360);
   			//transform.Rotate(0.0,0.0,Random.Range(30, 360));
   			transform.Rotate(0.0,0.0,Random.Range(30, 360), Space.World);
   			//rigidbody.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
   		}
   		

	}
//}

function OnTriggerEnter(other: Collider)
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

function OnTriggerExit(other: Collider)
{
	Debug.Log("End Collision");
	colliding = false;
}

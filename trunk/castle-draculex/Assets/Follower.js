#pragma strict	


var leader : Transform; 

var speed : float = 3; // The speed of the follower 

var colliding : boolean = false;
 
 
function Start () {
	transform.LookAt(leader);
}
var hit : RaycastHit;

function FixedUpdate(){ 
	
	
		var distance = Vector3.Distance(leader.position, transform.position);
		
		if(distance < 7) {
		   	transform.LookAt(leader);
		   	speed = 7;  
	   	}
	   	else {
	   		if (Random.Range(0, 100) <= 1)
	   		{
				transform.localEulerAngles.x = Random.Range(30, 360);
			}
			speed = 3;
	   	}
	   	
   		rigidbody.MovePosition(rigidbody.position + transform.forward * speed * Time.deltaTime);
	}
//}

function OnTriggerEnter(other: Collider)
{
	Debug.Log("Collision Start");
	colliding = true;
	//Debug.Break();
	
}

function OnTriggerExit(other: Collider)
{
	Debug.Log("End Collision");
	colliding = false;
}

#pragma strict	


var leader : Transform; 

var speed : float = 5; // The speed of the follower 

var colliding = false;

 
function Start () {
	transform.LookAt(leader);
}

function FixedUpdate(){ 
	
	
	if (!colliding) {
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
}

function OnTriggerEnter(other: Collider)
{
	Debug.Log("Collision");
	colliding = true;
	
}

function OnTriggerExit(other: Collider)
{
	Debug.Log("End Collision");
	colliding = false;
}

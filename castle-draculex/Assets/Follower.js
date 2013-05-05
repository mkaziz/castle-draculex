#pragma strict


var leader : Transform; 

var speed : float = 5; // The speed of the follower 


 
function Start () {

}

function Update(){ 
	
	var distance = Vector3.Distance(leader.position, transform.position);
	
	if (distance < 7) {
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
   	
   	transform.Translate(speed*Vector3.forward*Time.deltaTime);

}



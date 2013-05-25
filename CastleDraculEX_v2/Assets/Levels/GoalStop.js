#pragma strict	


var player : Transform; 
var nextLevel : Transform;

var speed : float = 3; // The speed of the follower 

var colliding : boolean = false;
 
 
function Start () {
	//transform.LookAt(pal);
}
var hit : RaycastHit;

function FixedUpdate(){ 
	
	   	
	   	if (colliding) {
   			Debug.Log("Yay you won!");
   			Application.LoadLevel(nextLevel.name);
   		}
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

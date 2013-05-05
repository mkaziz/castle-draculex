#pragma strict


var leader : Transform; 

var speed : float =5; // The speed of the follower 

 
function Start () {

}

function Update(){ 

   transform.LookAt(leader); 
   transform.Translate(speed*Vector3.forward*Time.deltaTime); 

}



#pragma strict


var hidden : boolean = false;

function Start () {

}

function Update () {
Debug.Log("update"); 
}

function OnCollisionEnter(theCollision : Collision){
       Debug.Log("collision");   
    if (theCollision.gameObject.name == "HidingPlace"){
       hidden = false;
       Debug.Log("hidden");       
    }
}

function OnCollisionExit(theCollision : Collision){
    if (theCollision.gameObject.name == "HidingPlace"){
       hidden = true;
       Debug.Log("no longer hidden");       
    }
}
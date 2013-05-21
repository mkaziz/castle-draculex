#pragma strict

function Start () {

}

function Update () {

}

function OnTriggerEnter(other: Collider)
{
	var player = GameObject.FindWithTag("Player");
	Debug.Log("Patch Collision Start");
	if (other.collider === player.collider) {
		Debug.Log("Patch player detected");
		//var playerHidingScript : HidingPlayer = player.gameObject.GetComponent("HidingPlayer");
		//playerHidingScript.hidden = true;	
	}
	
}

function OnTriggerExit(other: Collider)
{
	var player = GameObject.FindWithTag("Player");
	Debug.Log("Patch End Collision");
	if (other.collider === player.collider) {
		//var playerHidingScript : HidingPlayer = player.gameObject.GetComponent("HidingPlayer");
		//playerHidingScript.hidden = false;	
	}
}
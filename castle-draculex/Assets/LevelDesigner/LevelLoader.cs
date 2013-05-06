using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelLoader : MonoBehaviour {
	
	protected Map myMap = new Map();
	Room current_room = new Room();
	Room load_room = new Room();
	public Transform prefabRoom;
	
	
	void Awake() {
		//TODO: this generator
		//generate door dictionary
		//load first room into current room
		//TODO : assign this room a number after it has been created
		Component rm = (Component)Instantiate(prefabRoom, new Vector3(0,0,0), Quaternion.identity);
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//TODO : decide if we need to load a new room, and if so, do it.
		/*if (current_room != load_room)
		{
			Component rm = (Component)Instantiate(prefabRoom, new Vector3(0,0,0), Quaternion.identity);
			
		}*/
	
	}
}

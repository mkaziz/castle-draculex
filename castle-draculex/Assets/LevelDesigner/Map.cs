using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Map.
/// Keeps track of all room configurations
/// </summary>

public class Map : MonoBehaviour {
	
	public int tilesize = 1;
	public int level_z = 5;
	//public Dictionary<Room> room_dict = new Dictionary<Room>();
	public DoorDictionary door_dictionary = new DoorDictionary();
	public int num_rooms = 0;
	
	//number rooms from 1
	
	void Awake () {
		
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void MapParser() {
		
	}
}

/// <summary>
/// Door dictionary - keeps track of all of the doors in the entire map, and how rooms are connected via these doors.
/// </summary

public class DoorDictionary {
	
	Dictionary<DoorDictionaryKey, DoorDictionaryKey> door_dict = new Dictionary<DoorDictionaryKey, DoorDictionaryKey>();
	
	public void addDoorEntry(int in_room_num, char door_letter, int connects_to_room_num, char connect_door_letter){
		DoorDictionaryKey entry = new DoorDictionaryKey(in_room_num, door_letter);
		DoorDictionaryKey exit = new DoorDictionaryKey(connects_to_room_num, connect_door_letter);
		door_dict.Add(entry, exit);
	}
	
	public DoorDictionaryKey getConnectionByRoomAndDoor(int in_room_num, char door_letter) {
		DoorDictionaryKey k = new DoorDictionaryKey(in_room_num, door_letter);
		DoorDictionaryKey val = null;
		door_dict.TryGetValue(k, out val);
		if (val == null) {
			Debug.Log ("Tried to lookup a door that doesn't exist in the door dictionary.");
		}
		return val;
	}
	
}

public class DoorDictionaryKey {
	int in_room_num;
	char door_letter;
			
	public DoorDictionaryKey(int r, char d) {//, int c) {
				in_room_num = r;
				door_letter = d;
			}
}

public class EntryKey {
	
}

using UnityEngine;
using System.Collections; 

public abstract class Tile : LevelLoader {// : MonoBehaviour {
	//type
	//properties
	//collision/interaction
	//public Transform prefabTile;
	protected Transform myTile;
	public int tilesize = 20; //master tilesize is in Map

	public Vector3 position = new Vector3(0,0,0);
	public Color tcolor = Color.yellow;
	public bool obstacle = false;
	protected int room_num = -1;
	
	public Tile(Transform mt, Vector3 myPosition, int rn) {
		tilesize = new Map().tilesize;
		position = myPosition;
		myTile = mt;
		room_num = rn;
		
		//var myTile = (Transform)Instantiate(prefabTile, myPosition, Quaternion.identity);
		//Vector3 s = myTile.transform.localScale;
		//myTile.transform.localScale = new Vector3(tilesize, tilesize, s.z);
	}
	
	public abstract void collide();
	
	// Use this for initialization
	void Start () {
		/*Vector3 s = prefabTile.transform.localScale;
		prefabTile.transform.localScale = new Vector3(tilesize, tilesize, s.z);
		myTile = (Transform)MonoBehaviour.Instantiate(prefabTile, position, Quaternion.identity);*/
	}
	
	// Update is called once per frame
	void Update () {}
	
	//public virtual void collide();
	
}

public class Floor : Tile {
	
	public Floor(Transform mt, Vector3 position, int rn) : base(mt, position, rn) {
		tcolor = Color.black;
		myTile.renderer.material.color = tcolor;	
	}
	public override void collide() {
		//do nothing
	}
	
	
}


public class Wall : Tile {
	
	//BoxCollider collide = new BoxCollider();
	
	public Wall(Transform mt, Vector3 position, int rn) : base(mt, position, rn) {
		obstacle = true;
		tcolor = Color.white;
		myTile.renderer.material.color = tcolor;
		myTile.transform.localScale = new Vector3(myTile.localScale.x, myTile.localScale.y, 5);
	}
	
	public override void collide(){
		//TODO: collision detection
	}

}

public class Door : Tile {
	//TODO: how to encode this? Use letters? door A in room 5 connects to room 3?
	public char letter {get; set; }
	
	public Door(Transform mt, Vector3 position, int rn) : base(mt, position, rn) {
		tcolor = Color.blue;
		myTile.renderer.material.color = tcolor;
	}
	
	public override void collide() {
		// TODO: When you collide with a door, it should load a room based on the door dictionary in map
		//		get the appropriate room number
		// 		load that room
		//DoorDictionaryKey dest = myMap.door_dictionary.getConnectionByRoomAndDoor(room_num, letter);
		
	}
}


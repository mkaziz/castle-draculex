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
	protected int room_num = -1;
	
	//save values of room from the room this was initialized in
	public Tile(Transform mt, Vector3 myPosition, int rn) {
		tilesize = new Map().tilesize;
		position = myPosition;
		myTile = mt;
		room_num = rn;
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
		myTile.renderer.material.mainTexture = (Texture2D) Resources.Load("FloorTexture", typeof(Texture2D));
	}
	
	public override void collide() {
		//do nothing
	}
	
	
}


public class Wall : Tile {
	
	public Wall(Transform mt, Vector3 position, int rn) : base(mt, position, rn) {
		myTile.renderer.material.mainTexture = (Texture2D) Resources.Load("WallTexture", typeof(Texture2D));
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
		//tcolor = Color.blue;
		//myTile.renderer.material.color = tcolor;
		myTile.renderer.material.mainTexture = (Texture2D) Resources.Load("DoorTexture", typeof(Texture2D));
		//myTile.renderer.material = (Material)Resources.Load("DoorTile", typeof(Material));
		
	}
	
	public override void collide() {
		// TODO: When you collide with a door, it should load a room based on the door dictionary in map
		//		get the appropriate room number
		// 		load that room
		//DoorDictionaryKey dest = myMap.door_dictionary.getConnectionByRoomAndDoor(room_num, letter);
		
	}
}


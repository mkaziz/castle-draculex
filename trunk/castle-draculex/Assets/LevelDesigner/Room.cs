using UnityEngine;
using System.Collections;
using System.IO;
using System;
using System.Collections.Generic;

public class Room : MonoBehaviour {
	//room size
	//room configuration
	
	bool loaded = false;
	 int[,] RoomMap;
	
	public Component room_component;
	
	enum tileType {Floor, Wall, Door};
	
	public Transform prefabTile;
	
	List<Door> door_list = new List<Door>();
	
	protected int room_number = 1; //TODO: change to -1
	
	int tilesize = 20;  //master tilesize is in Map
	int sizeX = 0;
	int sizeY = 0;
	int depth = -1;
	
	public Room() {}
	
	/*public Room(int rm_number, Component rm_component){
		room_number = rm_number;
		room_component = rm_component;
	}*/

	
	void Awake () {
	//void Update() {
		
		//if (!loaded && room_number!=-1) {
		//GameObject o = (GameObject)Resources.Load ("Assets/LevelDesigner/TileObject");
		//prefabTile = o.transform;
		//prefabTile = (Transform) o;
		
		tilesize = new Map().tilesize;
		depth = new Map().level_z;
		
		RoomMap = GetRoom(room_number);
		
		int numtiles = sizeX * sizeY;
		
		
		prefabTile.transform.localScale = new Vector3(tilesize, tilesize, depth);
		
		for (int y = 0; y < sizeY; y++) {
			for (int x=0; x < sizeX; x++) {
				
				//center room
				Vector3 pos = new Vector3(tilesize*x, -tilesize*y, depth);
				float halfy = sizeY*tilesize/2;
				float halfx = sizeX*tilesize/2;
				Vector3 adjustment = new Vector3(-halfx, halfy, 0); //center room
				Vector3 current_pos = pos + adjustment;
				
				var myTile = (Transform)Instantiate(prefabTile, current_pos, Quaternion.identity);
				//myTile.transform.localScale = new Vector3(tilesize, tilesize, depth);
				
				switch (RoomMap[x,y]) {
				case (int)tileType.Floor:
					Floor ftile = new Floor(myTile, current_pos, room_number);
					break;
				case (int)tileType.Wall: 
					Wall wtile = new Wall(myTile, current_pos, room_number);
					break;
				case (int)tileType.Door:
					Door dtile = new Door(myTile, current_pos, room_number);
					door_list.Add(dtile);
					break;
				default:
					Debug.Log ("Unrecognized character in room "+room_number+" text file.");
					break;
				}

			}
		}
		}	
		
	//}
	
	
	// Update is called once per frame
	/*void Update () {
	
	}*/
	
 	int[,] GetRoom(int num)
     {
		
		//get full path for file
		string pathname = "Assets/LevelDesigner/Levels/Rooms/";
		string filename = "Room" + num + ".txt";
        string path = System.IO.Path.GetFullPath(pathname + filename);

          List<List<int>> lvl = new List<List<int>>();
		
		
		//get lines from file and size of array
          int row_count = 0;
          int col_count = 0;
		  List<string> lines = new List<string>();
          try
          {
               using (StreamReader sr = new StreamReader(path))
               {
					String line;
					while ((line = sr.ReadLine()) != null) {
                    //String line = sr.ReadLine();
                    lines.Add(line);
					if (line.Length > col_count) { col_count = line.Length; }
					row_count++;
					}
                    /*int col_ct = 0;
                    List<int> row = new List<int>();
                    foreach (char letter in letters)
                    {
                         row.Add((int)Char.GetNumericValue(letter));
                         col_ct++;
                    }
                    lvl.Add(row);
                    row_count++;
                    col_count = col_ct;*/

               }
          }
          catch (Exception e)
          {
			
				Debug.Log("The file could not be read:");
          		Debug.Log(e.Message);
          }
		
		
		//put these chars into the array as integers
          int[,] t = new int[col_count, row_count];
          int y = 0;
          foreach (string line in lines)
          {
               char[] chars = line.ToCharArray();
			   int x = 0;
               foreach (char c in chars) {
				t[x, y] = (int)Char.GetNumericValue(c);
				x++;
			}
			y++;
          }
		
		sizeX = col_count;
		sizeY = row_count;
		
        return t;

     }
}

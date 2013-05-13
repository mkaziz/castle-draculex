using UnityEngine;
using System.Collections;



public class TileSizeChild : MonoBehaviour {
	int tile_size = 2;
	// Use this for initialization
	void Start () {
		foreach (Transform child in transform) {
			float scaleX = child.transform.localScale.x;
       		float scaleY = child.transform.localScale.y;
			float myx = scaleX/tile_size;
			float myy = scaleY/tile_size;
        	child.renderer.material.mainTextureScale = new Vector2 (myx, myy);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	}
}

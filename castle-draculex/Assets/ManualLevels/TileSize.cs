using UnityEngine;
using System.Collections;

public class TileSize : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float scaleX = transform.localScale.x;
       	float scaleY = transform.localScale.y;
		float scalefactor = 10;
		float myx = scaleX/scalefactor;
		float myy = scaleY/scalefactor;
        renderer.material.mainTextureScale = new Vector2 (myx, myy);
	
	}
	
	// Update is called once per frame
	void Update () {
	}
}

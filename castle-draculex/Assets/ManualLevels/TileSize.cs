using UnityEngine;
using System.Collections;

public class TileSize : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float scaleX = transform.localScale.x;
       	float scaleY = transform.localScale.y;
        renderer.material.mainTextureScale = new Vector2 (scaleX,scaleY);
	
	}
	
/*	// Update is called once per frame
	void Update () {
	}*/
}

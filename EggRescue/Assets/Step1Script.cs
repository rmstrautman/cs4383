using UnityEngine;
using System.Collections;

public class Step1Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector2 SS = renderer.material.mainTextureScale;
		SS.x = transform.localScale.x / 8;
		SS.y = transform.localScale.y / 8;
		renderer.material.mainTextureScale = SS;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

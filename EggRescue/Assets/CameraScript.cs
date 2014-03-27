using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {

		//transform.LookAt (target);

	}

	void Update() {

		transform.position = new Vector3 (target.position.x - 10.0f, target.position.y + 10.0f, target.position.z - 10.0f);

		}
}

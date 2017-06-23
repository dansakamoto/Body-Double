using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jittermove : MonoBehaviour {

	float startx, starty, startz;
	GameObject anchorCube;
	Vector3 startPos;

	// Use this for initialization
	void Start () {
		startx = transform.rotation.eulerAngles.x;
		starty = transform.rotation.eulerAngles.y;
		startz = transform.rotation.eulerAngles.z;
	
	}

	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Euler (startx + (Random.value - .5f), starty, startz);
	}
}

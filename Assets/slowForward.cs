using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowForward : MonoBehaviour {

	public bool forward = true;
	public int speed = 1;
	int rate;

	// Use this for initialization
	void Start () {
		rate = 2000 / speed;
	}
	
	// Update is called once per frame
	void Update () {
		if (forward) {
			transform.position = transform.position + (Vector3.forward / rate);
		} else {
			transform.position = transform.position + (Vector3.back / rate);
		}
	}
}

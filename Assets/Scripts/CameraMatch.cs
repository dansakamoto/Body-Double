using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMatch : MonoBehaviour {

	public GameObject cam;

	// Use this for initialization
	void Start () {
		cam = GameObject.Find ("Wide Camera");
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion q = transform.rotation;
		cam.transform.localRotation = new Quaternion(q.x, q.y, q.z, q.w);
	}
}

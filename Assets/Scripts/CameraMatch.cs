using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMatch : MonoBehaviour {

	public GameObject cam, camHousing;
	Quaternion offset;

	public void setOffset(){
		offset = transform.rotation;
		camHousing.transform.rotation = Quaternion.Inverse (offset);// * Quaternion.Euler(90.0f, 0.0f, 0.0f);
	}

	// Use this for initialization
	void Start () {
		cam = GameObject.Find ("Wide Camera");
		camHousing = GameObject.Find ("Camera Housing");
		//offset = transform.rotation;
		offset = Quaternion.Euler (0f, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		//Quaternion q = transform.rotation;
		cam.transform.localRotation = transform.rotation; // * Quaternion.Inverse (offset) * Quaternion.Euler(-90.0f, 0.0f, 0.0f);
		//camHousing.transform.localRotation = transform.rotation * Quaternion.Inverse(offset) * Quaternion.Euler(90.0f, 0.0f, 0.0f);
	}
}

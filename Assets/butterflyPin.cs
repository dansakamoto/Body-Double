using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butterflyPin : MonoBehaviour {

	public GameObject butterfly, wing;
	Vector3 locPos, fStartPos, offset, wingPos, initialDiff, wingRot, initRot;
	public float wx, wy, wz, fx, fy, fz, initx, inity, initz;

	// Use this for initialization
	void Start () {

		wingPos = wing.transform.position;
		initialDiff = wingPos - transform.position;
		butterfly.transform.localPosition = butterfly.transform.localPosition - initialDiff;
	
		transform.position = wingPos;


		wingRot = wing.transform.rotation.eulerAngles;
		initRot = transform.localRotation.eulerAngles;

		initx = wing.transform.rotation.eulerAngles.x;
		inity = wing.transform.rotation.eulerAngles.y;
		initz = wing.transform.rotation.eulerAngles.z;

		GameObject.Find ("RefCube").transform.localPosition = new Vector3 (0f, 0f, 0f);
	



	}

	// Update is called once per frame
	void Update () {

		Vector3 newDiff = wing.transform.position - transform.position;
		butterfly.transform.position = butterfly.transform.position - newDiff;

		float curx = wing.transform.rotation.eulerAngles.x;
		float cury = wing.transform.rotation.eulerAngles.y;
		float curz = wing.transform.rotation.eulerAngles.z;


		//Vector3 rotDiff = wing.transform.localRotation.eulerAngles - wingRot;
		//transform.rotation = Quaternion.FromToRotation (wingRot, wing.transform.rotation.eulerAngles);

		transform.rotation =  Quaternion.Euler(new Vector3(initx + curx, inity - cury, initz + curz));

	}
}

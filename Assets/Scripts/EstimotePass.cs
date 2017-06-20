using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class EstimotePass : NetworkBehaviour {

	public double us = 0, ds = 0, sl = 0, sr = 0;
	double oldus = 0, oldds = 0, oldsl = 0, oldsr = 0;
	float currentx = 0f, currentz = 0f;
	float targetx = 0f, targetz = 0f;

	public float smoothing = 60f, snapping = .001f, sensitivity = 1f, slmod = 1f, srmod=2.1f, usmod=3f, dsmod=1.2f;

	//public float xSensitivity = 1f, zSensitivity = 1f;
	GameObject camHousing, cam;

	protected void Start(){
		camHousing = GameObject.Find ("Camera Housing");
		cam = GameObject.Find ("Wide Camera");
	}

	protected void Update(){

		if (oldsl != sl || oldsr != sr) {
			targetx = (float)((sr*srmod) - (sl*slmod)) / 2f;
		}

		if (oldus != us || oldds != ds) {
			targetz = (float)((ds*dsmod) - (us*usmod)) / 2f;
		}

		if (currentx != targetx) {

			if (Mathf.Abs (targetx - currentx) < snapping) {
				currentx = targetx;
			} else {
				currentx += ((targetx - currentx) / smoothing);
			}
		}

		if (currentz != targetz) {
			if (Mathf.Abs (targetz - currentz) < snapping){
				currentz = targetz;
			} else {
				currentz += ((targetz - currentz) / smoothing);
			}
		}


		camHousing.transform.position = new Vector3 (currentx*sensitivity, camHousing.transform.position.y, currentz*sensitivity);
	}

	[Command]
	public void CmdSetUS(double x){
		us = x;
	}

	[Command]
	public void CmdSetDS(double x){
		ds = x;
	}

	[Command]
	public void CmdSetSR(double x){
		sr = x;
	}

	[Command]
	public void CmdSetSL(double x){
		sl = x;
	}

	[Command]
	public void CmdSetOffset(){
		//setOffset = true;
		//Debug.Log("It worked");
		//camHousing.transform.Rotate(new Vector3(0f, 0f, cam.transform.rotation.eulerAngles.z*-1f));
		this.GetComponent<CameraMatch>().setOffset();
	}

}

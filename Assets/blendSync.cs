using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blendSync : MonoBehaviour {

	SkinnedMeshRenderer syncRef, mySkin;

	// Use this for initialization
	void Start () {
		syncRef = GameObject.FindGameObjectWithTag ("BlendRef").GetComponent<SkinnedMeshRenderer>();
		mySkin = GetComponent<SkinnedMeshRenderer>();
	}

	// Update is called once per frame
	void Update () {
		for (int i = 0; i < 136; i++) {
			mySkin.SetBlendShapeWeight (i, syncRef.GetBlendShapeWeight (i));
		}
	}
}



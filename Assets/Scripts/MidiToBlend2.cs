using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidiToBlend2 : MonoBehaviour {

	public int[] patches;

	public GameObject head;
	SkinnedMeshRenderer smr;
	Mesh skinnedMesh;

	float headX = 0f, headY =0f;

	MidiHandler midiVal;

	void Awake () {
		smr = GetComponent<SkinnedMeshRenderer> ();
		skinnedMesh = GetComponent<SkinnedMeshRenderer> ().sharedMesh;
		midiVal = GameObject.Find ("MIDI Handler").GetComponent<MidiHandler> ();
	}
		
	void Update () {

		for (int i = 0; i < patches.Length; i++) {
			// smr.SetBlendShapeWeight (patches[i], midiVal.knobs[i]*100f);  Attempting to reverse

			if (patches [i] != 0) {
				if (patches [i] < 200) {
					if (patches [i] == 59 || patches [i] == 60) {
						smr.SetBlendShapeWeight (patches [i], 100f - midiVal.knobs [i] * 100f);
					} else {
						smr.SetBlendShapeWeight (patches [i], midiVal.knobs [i] * 100f);
					}
				} else {

					if (patches [i] == 201){
						headY = (midiVal.knobs [i] * -180f)-90f;
					} else if (patches [i] == 202){
						headX = (midiVal.knobs [i] * -180f)+90f;
					}

					head.transform.rotation = Quaternion.Euler (headX, headY, 0f);
				}






			}
		}

	}
}

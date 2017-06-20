using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidiToBlend : MonoBehaviour {

	public int[] patches;

	SkinnedMeshRenderer smr;
	Mesh skinnedMesh;

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
				smr.SetBlendShapeWeight (i, midiVal.knobs [patches [i]] * 100f);
			}
		}

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class MidiHandler : MonoBehaviour {

	public float[] knobs;

	void Start () {

	}

	void Update () {

		for (int i = 0; i < knobs.Length; i++) {
			knobs[i] = MidiMaster.GetKnob (i, 0f);
		}

	}
}
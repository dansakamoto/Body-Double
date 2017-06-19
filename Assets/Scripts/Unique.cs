using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unique : MonoBehaviour {

	void Awake(){

		// Object searches for an object with the same name as it + prefix “Unique”
		GameObject testUnique = GameObject.Find("Unique "+this.gameObject.name);
		if(testUnique==null){
			// if it can’t find one, it appends “Unique” to it’s own name and becomes persistent
			testUnique = this.gameObject;
			testUnique.name = "Unique "+testUnique.name;
			DontDestroyOnLoad(testUnique);
		} else {

			Destroy(this.gameObject); //another copy exists, object self-destructs
		}
	}

}

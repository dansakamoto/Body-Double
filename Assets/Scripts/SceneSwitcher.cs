using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update() {

		// CYCLING WITH SPACEBAR
		if (Input.GetKeyDown (KeyCode.Space)) { //check if the user is pressing space 
			// check what scene we’re currently in 
			int sceneIndex = SceneManager.GetActiveScene ().buildIndex; 
			// check if that matches the index of the last scene
			if (sceneIndex == SceneManager.sceneCountInBuildSettings - 1) {
				SceneManager.LoadScene (0); // if so, load the first scene
			} else { 
				SceneManager.LoadScene (sceneIndex + 1); // otherwise, load the next scene 
			}
		}
		

		// USING NUMBER KEYS
		if( Input.GetKeyDown( KeyCode.Alpha1 ) ) {
			SceneManager.LoadScene(0);
		}

		if( Input.GetKeyDown( KeyCode.Alpha2 ) ) {
			SceneManager.LoadScene(1);
		}

		if( Input.GetKeyDown( KeyCode.Alpha3 ) ) {
			SceneManager.LoadScene(2);
		}

		
	}
}

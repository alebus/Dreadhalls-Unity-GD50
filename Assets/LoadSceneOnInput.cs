using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnInput : MonoBehaviour {



	
private Scene scene;

	// Use this for initialization
	void Start () {
		

		// todo this shouldn't need to run every frame
		scene = SceneManager.GetActiveScene();


	}
	
	// Update is called once per frame
	void Update () {

		
		if (Input.GetAxis("Submit") == 1) {

			if (scene.name == "Title") {

				SceneManager.LoadScene("Play");

			} else if (scene.name == "DeathScreen") {

				SceneManager.LoadScene("Title");

			}		
		}
	}
}

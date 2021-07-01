using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrabPickups : MonoBehaviour {

	private AudioSource pickupSoundSource;

	void Awake() {
		pickupSoundSource = DontDestroy.instance.GetComponents<AudioSource>()[1];
	}

	void OnControllerColliderHit(ControllerColliderHit hit) {
		if (hit.gameObject.tag == "Pickup") {
			pickupSoundSource.Play();
			Debug.Log("Collide");
			UnityStandardAssets.Characters.FirstPerson.FirstPersonController.level += 1;
			Debug.Log("Level: " + UnityStandardAssets.Characters.FirstPerson.FirstPersonController.level);
			SceneManager.LoadScene("Play");
		}
	}
}

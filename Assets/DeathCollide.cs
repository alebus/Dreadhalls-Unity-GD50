using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCollide : MonoBehaviour {

//private AudioSource pickupSoundSource;

void Awake() {
		//pickupSoundSource = DontDestroy.instance.GetComponents<AudioSource>()[1];
	}

	void OnControllerColliderHit(ControllerColliderHit hit) {
		if (hit.gameObject.tag == "DeathZone") {

            // stop the audio 
            //pickupSoundSource.Play();
            Destroy(GameObject.FindGameObjectsWithTag("Whisper")[0]);
			SceneManager.LoadScene("DeathScreen");
            Debug.Log("Player hit DeathZone");
		}
	}
}

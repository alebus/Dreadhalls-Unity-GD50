using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathCollide : MonoBehaviour {


void Awake() {
		//pickupSoundSource = DontDestroy.instance.GetComponents<AudioSource>()[1];
	}

    
	void OnControllerColliderHit(ControllerColliderHit hit) {
		if (hit.gameObject.tag == "DeathZone") {

            // hide this so you don't see it flash "Level 1" as you die
            GameObject.Find("PlayerHUD").SetActive(false);

            // set the level back to 1
            UnityStandardAssets.Characters.FirstPerson.FirstPersonController.level = 1;

            // stop the audio 
            //pickupSoundSource.Play();
            Destroy(GameObject.FindGameObjectsWithTag("Whisper")[0]);
			SceneManager.LoadScene("DeathScreen");
            Debug.Log("Player hit DeathZone");
		}
	}
}

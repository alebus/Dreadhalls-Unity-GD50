using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHUD : MonoBehaviour
{


    private Text levelTxt;

    // Start is called before the first frame update
    void Start()
    {
        levelTxt = GameObject.FindObjectOfType<Text>();
    }

    // Update is called once per frame
    void Update()
    {
       
       // update the HUD with the current level
       levelTxt.text = "Level " + UnityStandardAssets.Characters.FirstPerson.FirstPersonController.level;
       //Debug.Log(levelTxt.text);
       //Debug.Log(UnityStandardAssets.Characters.FirstPerson.FirstPersonController.level);
    }
}

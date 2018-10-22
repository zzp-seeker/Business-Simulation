using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using FairyGUI;

public class StartGame : MonoBehaviour {

    GComponent mainUI;
    GButton startBtn;

	// Use this for initialization
	void Start () {
        mainUI = GetComponent<UIPanel>().ui;
        startBtn = mainUI.GetChild("start").asButton;
        startBtn.onClick.Add(() => {
            SceneManager.LoadScene("Loading");
        });

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;

public class SceneBrain : MonoBehaviour {

    GComponent mainUI;
	// Use this for initialization


	void Start () {
        mainUI = GetComponent<UIPanel>().ui;
        mainUI.MakeFullScreen();
    }

}

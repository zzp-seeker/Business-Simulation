using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;

public class test : MonoBehaviour {

    public GameObject gb;
    UIPanel uiPanel;

	// Use this for initialization
	void Start () {
        uiPanel = gb.GetComponent<UIPanel>();
        uiPanel.packageName = "szmnUI";
        uiPanel.componentName = "bagWindow";
        uiPanel.ui.MakeFullScreen();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

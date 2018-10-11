using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;

public class Bag : MonoBehaviour {

    GComponent mainUI;
    BagWindow bagWindow;



    void Start()
    {
        mainUI = GetComponent<UIPanel>().ui;
        bagWindow = new BagWindow();
        bagWindow.SetXY(400, 110);
        mainUI.GetChild("bag").onClick.Add(() => { bagWindow.Show(); });
    }

}

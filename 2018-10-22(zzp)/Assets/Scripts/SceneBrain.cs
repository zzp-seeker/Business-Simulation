using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;
using System;

public class SceneBrain : MonoBehaviour {

    GComponent mainUI;
    public string[] imgStr;
    public int designWidth, designHeight;
	// Use this for initialization


	void Start () {
        mainUI = GetComponent<UIPanel>().ui;
        mainUI.MakeFullScreen();

        for(int i=0;i<imgStr.Length;i++)
        {
            GImage img = mainUI.GetChild(imgStr[i]).asImage;
            float logicalWidth = GRoot.inst.width, logicalHeight = GRoot.inst.height;
            float logicalRatio = logicalWidth / logicalHeight; //逻辑比
            float designRatio = (float)designWidth / (float)designHeight;  //设计比
            float imgRatio = img.width / img.height;  //图像比
            Debug.Log(logicalRatio + ", " + designWidth+ "|" + designHeight + ":" + designRatio + ", " + img.width + "|" + img.height + ":" + imgRatio);
            if (logicalRatio < imgRatio)
            {
                img.SetSize(img.width * (logicalHeight / img.height), logicalHeight);
            }
            else
            {
                img.SetSize(logicalWidth, img.height * (logicalWidth / img.width));
            }
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using FairyGUI;

public class Loading : MonoBehaviour {

    GComponent mainUI;
    GProgressBar progressBar;


	// Use this for initialization
	void Start () {
        mainUI = GetComponent<UIPanel>().ui;
        progressBar = mainUI.GetChild("n1").asProgress;
        progressBar.value = 0;
        //SceneManager.LoadScene("MainUI");
        StartCoroutine(StartLoading());
	}
    IEnumerator StartLoading()
    {
        int x = 10;

        float toProgress;
        AsyncOperation op = SceneManager.LoadSceneAsync("MainUI");
        op.allowSceneActivation = false;
        while(op.progress<0.9f)
        {
            toProgress = op.progress * 100;
            while(progressBar.value<toProgress)
            {
                if (x++ > 1000) x = 10;
                progressBar.value+=(double)((new System.Random().Next(x,x*x)+(x-9)*(x+20))%1000)/1000;
                yield return new WaitForEndOfFrame();
            }            
        }
        toProgress = 100;
        while (progressBar.value < toProgress)
        {
            if (x++ > 1000) x = 10;
            progressBar.value += (double)((new System.Random().Next(x,x*x)+(x-9)*(x+20))%1000)/1000;
            yield return new WaitForEndOfFrame();
        }
        op.allowSceneActivation = true;
        yield return null;
    }

}

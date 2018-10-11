using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using FairyGUI;

public class MainUI : MonoBehaviour {

    public GameObject uIPanel;
    GComponent mainUI;


    GObject marketManagement; //市场管理
    GObject personnelManagement; //人事管理
    GObject productManagement; //产品管理
    GObject informationAnalysis; //情报分析
    GObject productionManagement; //生产管理
    GObject corporateCulture; //企业文化
    GObject endTurn;  //结束回合

    PersonnelManagementWindow perWindow;

    void InitValue() //赋值初始化处理
    {
        mainUI = uIPanel.GetComponent<UIPanel>().ui;

        marketManagement = mainUI.GetChild("marketManagement");
        personnelManagement = mainUI.GetChild("personnelManagement");
        productManagement = mainUI.GetChild("productManagement");
        informationAnalysis = mainUI.GetChild("informationAnalysis");
        productionManagement = mainUI.GetChild("productionManagement");
        corporateCulture = mainUI.GetChild("corporateCulture");
        endTurn = mainUI.GetChild("endTurn");

        perWindow = new PersonnelManagementWindow();
    }

    void InitEvent() //点击初始化处理
    {
        marketManagement.onClick.Add(() =>{
            SceneManager.LoadScene("Loading");
        });
        personnelManagement.onClick.Add(()=> { perWindow.Show(); });
        endTurn.onClick.Add(() => {
            Application.Quit();
        });
    }

    // Use this for initialization
    void Start()
    {
        InitValue();
        InitEvent();
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;
using System;

public class PersonnelManagementWindow : Window {

    GList list;

    protected override void OnInit()
    {
        GComponent target;
        target = UIPackage.CreateObject("szmnUI", "personnelManagementWindow").asCom;
        target.MakeFullScreen();
        this.contentPane = target;

        this.modal = true;
        UIConfig.modalLayerColor = new Color(200, 30, 100, 0.7f);
        list = this.contentPane.GetChild("list").asList;
        list.itemRenderer = RenderListItem;
        list.numItems = 10;
    }

    private void RenderListItem(int index, GObject obj)
    {
        GComponent com = obj.asCom;
        GLoader pe=com.GetChild("person").asLoader, 
            s1 = com.GetChild("s1").asLoader,
            s2 = com.GetChild("s2").asLoader, 
            s3 = com.GetChild("s3").asLoader, 
            s4 = com.GetChild("s4").asLoader, 
            s5 = com.GetChild("s5").asLoader;
        GTextField t = com.GetChild("label").asTextField,
            tNum = com.GetChild("numLabel").asTextField;

        int peIndex = index % 9 + 1;
        pe.url= UIPackage.GetItemURL("publicUI", "pe" + peIndex);

        string startURL= UIPackage.GetItemURL("szmnUI", "star"); ;
        if (index *7 %3+1==1)
        {
            s1.url = startURL;
            s2.url = "";
            s3.url = "";
            s4.url = "";
            s5.url = "";
        }
        else if(index * 7 % 3+1==2)
        {
            s1.url = "";
            s2.url = "";
            s3.url = "";
            s4.url = startURL;
            s5.url = startURL;
        }
        else
        {
            s1.url = startURL;
            s2.url = startURL;
            s3.url = startURL;
            s4.url = "";
            s5.url = "";
        }
        //Debug.Log(t);
        t.text = index + "\n可能有的相关职业，相关属性等";
        tNum.text = (index * 7 % 17).ToString();

        com.GetChild("add").onClick.Add(() => {
            if(int.Parse(tNum.text)<100000)
                tNum.text = (int.Parse(tNum.text) + 1).ToString();
        });
        com.GetChild("minus").onClick.Add(() => {
            if (int.Parse(tNum.text) > 0)
                tNum.text = (int.Parse(tNum.text) - 1).ToString();
        });
        //t.title = index + "\n可能有的相关职业，相关属性等";
    }
}

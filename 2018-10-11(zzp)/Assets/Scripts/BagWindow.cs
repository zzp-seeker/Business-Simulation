using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;

public class BagWindow : Window {

    GList list;

    public BagWindow()
    {

    }

    protected override void OnInit()
    {
        this.contentPane = UIPackage.CreateObject("szmnUI", "bagWindow").asCom;
        list = this.contentPane.GetChild("itemList").asList;
        list.itemRenderer = RenderListItem;
        list.numItems = 20;

    }

    private void RenderListItem(int index, GObject obj)
    {
        GButton button = obj.asButton;
        button.icon = UIPackage.GetItemURL("szmnUI", "i" + index);
        //Debug.Log(UIPackage.GetItemURL("szmnUI", "i" + index));
        button.title = "战神"+index;
    }

}

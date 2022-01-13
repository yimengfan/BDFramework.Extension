using System.Collections;
using System.Collections.Generic;
using BDFramework.FairyGUIEx;
using BDFramework.Hotfix.ScreenView;
using BDFramework.Extension.FairyGUI_hotfix;
using UnityEngine;

[ScreenView(1)]
public class ScreenView_1_FairyGUIDemo : IScreenView
{
    public int Name { get; set; }
    public bool IsLoad { get; set; }

    public void BeginInit()
    {
        //打开fairygui demo
        FairyGUIManager.Inst.LoadWindow((int) FairyDemoEnum.Basics);
        FairyGUIManager.Inst.Open((int) FairyDemoEnum.Basics);
    }
    public void BeginExit()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using BDFramework.Extension.FairyGUI;
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
        FairyGUIMgr.Inst.LoadWindow((int) FairyDemoEnum.Basics);
        FairyGUIMgr.Inst.Open((int) FairyDemoEnum.Basics);
    }
    public void BeginExit()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using BDFramework.Extension.FairyGUI;
using BDFramework.ScreenView;
using Code.BDFramework.Extension.FairyGUI_hotfix;
using UnityEngine;

[ScreenView(1)]
public class ScreenView_1_FairyGUIMgr : IScreenView
{
    public int Name { get; }
    public bool IsLoad { get; }

    public void BeginInit()
    {
        //打开fairygui demo
        FairyGUIMgr.Inst.Open((int)FairyDemoEnum.Basics);
    }

    public void BeginExit()
    {
        throw new System.NotImplementedException();
    }
}

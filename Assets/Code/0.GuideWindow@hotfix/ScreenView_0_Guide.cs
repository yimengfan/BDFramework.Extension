
using BDFramework.Extension.FairyGUI;
using BDFramework.Extension.FairyGUI_hotfix;
using BDFramework.Hotfix.ScreenView;
using UnityEngine;

[ScreenView(0)]
public class ScreenView_0_Guide : IScreenView
{
    public int Name { get; set; }
    public bool IsLoad { get; set; }

    public void BeginInit()
    {
        Debug.Log("----------------->进入默认sv");
        this.IsLoad = true;
        FairyGUIMgr.Inst.LoadWindow((int) FairyDemoEnum.Basics);
        FairyGUIMgr.Inst.Open((int) FairyDemoEnum.Basics);
    }

    public void BeginExit()
    {
    }
}

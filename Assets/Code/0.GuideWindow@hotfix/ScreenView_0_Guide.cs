using BDFramework.Extension.FairyGUI;
using BDFramework.Extension.FairyGUI_hotfix;
using BDFramework.Hotfix.ScreenView;
using BDFramework.UFlux;
using UnityEngine;

namespace BDFramework.Extension.Demo
{
    [ScreenView(0)]
    public class ScreenView_0_Guide : IScreenView
    {
        public int Name { get; set; }
        public bool IsLoad { get; set; }

        public void BeginInit()
        {
            Debug.Log("----------------->进入默认sv");
            this.IsLoad = true;
            UIManager.Inst.LoadWindow(WindowEnum.Guide);
            UIManager.Inst.ShowWindow(WindowEnum.Guide);
        }

        public void BeginExit()
        {
        }
    }
}

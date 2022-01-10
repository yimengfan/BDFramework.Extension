using System.Linq;
using BDFramework.Hotfix.ScreenView;
using BDFramework.UFlux;
using UnityEngine;
using UnityEngine.UI;

namespace BDFramework.Extension.Demo
{
    /// <summary>
    /// 这个页面会遍历所有的ScreenView,方便能导航过去
    /// </summary>
    [UI((int) WindowEnum.Guide, "Uflux/Window_Guide")]
    public class Window_Guide : AWindow
    {
        public Window_Guide(string path) : base(path)
        {
        }

        public Window_Guide(Transform transform) : base(transform)
        {
        }


        public override void Open(UIMsgData uiMsg = null)
        {
            base.Open(uiMsg);
            //网格
            var layout = this.Transform.Find("GridLayout").GetComponent<GridLayoutGroup>();
            var btn = layout.transform.GetChild(0);
            //创建cls
            var svList = ScreenViewManager.Inst.GetAllClassDatas().ToList();
            for (int i = 1; i < svList.Count; i++)
            {
                var _btn = GameObject.Instantiate(btn);
                _btn.transform.SetParent(layout.transform, false);
            }

            //
            for (int i = 0; i < svList.Count; i++)
            {
                var svData = svList[i];
                //
                var btnTrans = layout.transform.GetChild(svList.Count - i - 1);
                var strs = svData.Type.Name.Split('_');
                btnTrans.GetChild(0).GetComponent<Text>().text = "【执行Demo】 " + strs.LastOrDefault();
                btnTrans.GetComponent<Button>().onClick.AddListener(() =>
                {
                    //按钮回调进入不同demo
                    ScreenViewManager.Inst.MainLayer.BeginNavTo(svData.Attribute.IntTag);
                });
            }
        }
    }
}

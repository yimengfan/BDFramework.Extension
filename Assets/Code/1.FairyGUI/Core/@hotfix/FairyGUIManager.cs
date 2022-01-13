using System;
using System.Collections.Generic;
using BDFramework.Mgr;
using BDFramework.ResourceMgr;
using FairyGUI;
using UnityEngine;

namespace BDFramework.FairyGUIEx
{

    /// <summary>
    /// FairyGUI的管理器
    /// </summary>
    public class FairyGUIManager : ManagerBase<FairyGUIManager, FGUIAttribute>
    {
        /// <summary>
        /// 全局的UIPanel
        /// </summary>
        public UIPanel MainUIPanel { get; private set; }

        public override void Start()
        {
            //ILruntime的注册
           // ILRuntimeHelper.AppDomain?.RegisterCrossBindingAdaptor(new FGUIWindowAdaptor());
            //节点逻辑处理
            var uiroot = GameObject.Find("FairyGUIRoot");//<UIPanel>();
            if (!uiroot)
            {
                var obj = BResources.Load<GameObject>("FairyGUIRoot");
                uiroot = GameObject.Instantiate(obj);
                uiroot.name = "FairyGUIRoot";
            }
            this.MainUIPanel = uiroot.GetComponentInChildren<UIPanel>();
        }


        /// <summary>
        /// FGUI的map容器
        /// 这里public是为了方便partial扩展类访问
        /// </summary>
        public Dictionary<int, AFGUIWindowContainer> FGUIWindowMap { get; private set; } = new Dictionary<int, AFGUIWindowContainer>();


        /// <summary>
        /// 加载window
        /// </summary>
        /// <param name="windowEnum"></param>
        public void LoadWindow(Enum windowEnum)
        {
            this.LoadWindow(windowEnum.GetHashCode());
        }


        /// <summary>
        /// 加载Window
        /// </summary>
        /// <param name="uiTag"></param>
        public void LoadWindow(int uiTag)
        {
            this.FGUIWindowMap.TryGetValue(uiTag, out var fguiWindow);
            if (fguiWindow == null)
            {
                var window = this.CreateInstance<AFGUIWindowContainer>(uiTag);
                //获取ui配置
                var cd = this.GetClassData(uiTag);
                var fguiAttr = cd.Attribute as FGUIAttribute;
                //创建ui
                FairyGUILoader.LoadPackage(fguiAttr.PackagePath);
                this.MainUIPanel.packageName = fguiAttr.PackageName;
                this.MainUIPanel.componentName = fguiAttr.DefaultComponentName;
                this.MainUIPanel.CreateUI();
                //panel赋值
                window.MainUIPanel = this.MainUIPanel;
                window.Awake();
                //压入容器
                this.FGUIWindowMap[uiTag] = window;
            }
            else
            {
                BDebug.LogError("【FairyGUIMgr】窗口已经加载:" + uiTag);
            }
        }

        /// <summary>
        /// 打开窗口
        /// </summary>
        public void Open(int uiTag)
        {
            this.FGUIWindowMap.TryGetValue(uiTag, out var fguiWindow);
            if (fguiWindow != null)
            {
                fguiWindow.Open();
            }
            else
            {
                BDebug.LogError("【FairyGUIMgr】窗口未加载：" + uiTag);
            }
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        public void Close(int uiTag)
        {
            this.FGUIWindowMap.TryGetValue(uiTag, out var fguiWindow);
            if (fguiWindow != null)
            {
                fguiWindow.Close();
            }
            else
            {
                BDebug.LogError("【FairyGUIMgr】窗口未加载：" + uiTag);
            }
        }
    }
}

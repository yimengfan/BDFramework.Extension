using System;
using System.Collections.Generic;
using BDFramework.Mgr;
using BDFramework.ResourceMgr;
using FairyGUI;
using UnityEngine;
using UnityEngine.UI;

namespace BDFramework.Extension.FairyGUI
{
    /// <summary>
    /// FGUI的标签
    /// </summary>
    public class FGUIAttribute : ManagerAttribute
    {
        /// <summary>
        /// fairyGui 包路径
        /// </summary>
        public string PackagePath;

        /// <summary>
        /// 包名
        /// </summary>
        public string PackageName;

        /// <summary>
        /// 默认的第一页
        /// </summary>
        public string DefaultComponentName;

        /// <summary>
        /// int类型构造
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="packagePath"></param>
        /// <param name="packageName"></param>
        /// <param name="defaultComponentName"></param>
        public FGUIAttribute(int tag, string packagePath, string packageName, string defaultComponentName = "Main") : base(tag)
        {
            this.PackagePath = packagePath;
            this.PackageName = packageName;
            this.DefaultComponentName = defaultComponentName;
        }

        // /// <summary>
        // /// 枚举的构造
        // /// </summary>
        // /// <param name="tag"></param>
        // /// <param name="packagePath"></param>
        // /// <param name="packageName"></param>
        // /// <param name="defaultComponentName"></param>
        // public FGUIAttribute(Enum tag, string packagePath, string packageName, string defaultComponentName = "Main") : base(tag.GetHashCode())
        // {
        //     this.PackagePath = packagePath;
        //     this.PackageName = packageName;
        //     this.DefaultComponentName = defaultComponentName;
        // }
    }

    /// <summary>
    /// FairyGUI的管理器
    /// </summary>
    public partial class FairyGUIMgr : ManagerBase<FairyGUIMgr, FGUIAttribute>
    {
        /// <summary>
        /// 全局的UIPanel
        /// </summary>
        public UIPanel MainUIPanel { get; private set; }

        /// <summary>
        /// 注册到ILruntime
        /// </summary>
        public void RegisterToILRuntime()
        {
        }

        public override void Start()
        {
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

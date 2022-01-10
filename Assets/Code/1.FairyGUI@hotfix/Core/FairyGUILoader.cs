using BDFramework.ResourceMgr;
using FairyGUI;
using UnityEngine;

namespace BDFramework.Extension.FairyGUI
{
    static public class FairyGUILoader
    {
        //Tips: 需要按照BDFramework的规范，将fgui文件放置到Runtime下
        static UIPackage.LoadResource _loader = (string name, string extension, System.Type type, out DestroyMethod destroyMethod) =>
        {
            destroyMethod = DestroyMethod.Unload;
            return BResources.Load(type,name);
        };

        /// <summary>
        /// 加载Package
        /// </summary>
        static public void LoadPackage(string packagePath)
        {
            UIPackage.AddPackage(packagePath, _loader);
        }
    }
}

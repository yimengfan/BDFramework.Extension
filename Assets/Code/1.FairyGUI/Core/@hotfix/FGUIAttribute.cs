using BDFramework.Mgr;

namespace BDFramework.FairyGUIEx
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
    }
}

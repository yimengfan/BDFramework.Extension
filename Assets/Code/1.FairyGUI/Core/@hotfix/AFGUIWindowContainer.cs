using FairyGUI;

namespace BDFramework.FairyGUIEx
{
    /// <summary>
    /// Windows容器基类，
    /// 用于封装windows逻辑，不是Fgui的windows对应关系
    /// </summary>
    abstract public class AFGUIWindowContainer
    {
        /// <summary>
        /// 挂载的UIPanel
        /// </summary>
        public UIPanel MainUIPanel { get; set; }

        /// <summary>
        /// 是否打开
        /// </summary>
        public bool IsOpen { get; protected set; }

        /// <summary>
        /// 激活
        /// </summary>
        virtual public void Awake()
        {
            
        }
        /// <summary>
        /// 打开
        /// </summary>
        virtual public void Open()
        {
            IsOpen = true;
        }

        /// <summary>
        /// 关闭
        /// </summary>
        virtual public void Close()
        {
            IsOpen = false;
        }
    }
}

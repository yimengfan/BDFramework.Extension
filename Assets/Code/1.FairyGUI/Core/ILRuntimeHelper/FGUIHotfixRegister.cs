using FairyGUI;
using ILRuntime.Runtime.Enviorment;

namespace BDFramework.Extension.FairyGUI
{
    static public class FGUIHotfixRegister
    {

        /// <summary>
        /// 注册适配器
        /// </summary>
        /// <param name="appDomain"></param>
        static public void RegisterAdaptor(AppDomain appDomain)
        {
            appDomain.RegisterCrossBindingAdaptor(new FGUIWindowAdaptor());
        }

        /// <summary>
        /// 注册delegate
        /// </summary>
        /// <param name="appDomain"></param>
        static public void RegisterDelegate(AppDomain appDomain)
        {
         
          //  appDomain.DelegateManager.RegisterFunctionDelegate<System.String, System.String, System.Type, DestroyMethod, System.Object>();

        }
        
    }
}

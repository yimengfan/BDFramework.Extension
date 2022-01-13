using System;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;

namespace BDFramework.FairyGUIEx
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
        static public void RegisterDelegate(AppDomain appdomain)
        {
            appdomain.DelegateManager.RegisterMethodDelegate<FairyGUI.EventContext>();

            appdomain.DelegateManager.RegisterDelegateConvertor<FairyGUI.EventCallback1>((act) =>
            {
                return new FairyGUI.EventCallback1((context) =>
                {
                    ((Action<FairyGUI.EventContext>)act)(context);
                });
            });
            appdomain.DelegateManager.RegisterDelegateConvertor<FairyGUI.EventCallback0>((act) =>
            {
                return new FairyGUI.EventCallback0(() =>
                {
                    ((Action)act)();
                });
            });



        }
        
    }
}

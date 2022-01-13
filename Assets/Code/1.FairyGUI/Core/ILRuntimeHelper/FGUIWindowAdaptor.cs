using System;
using FairyGUI;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using UnityEngine;

namespace BDFramework.Extension.FairyGUI
{
    /// <summary>
    /// 该类用于 hotfix下继承 Window的绑定
    /// </summary>
    public class FGUIWindowAdaptor : CrossBindingAdaptor
    {
        public override Type BaseCLRType
        {
            get { return typeof(Window); }
        }

        public override Type AdaptorType
        {
            get { return typeof(Adaptor); }
        }

        public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
        {
            return new Adaptor(appdomain, instance);
        }


        public class Adaptor : Window, CrossBindingAdaptorType
        {
            ILTypeInstance instance;
            ILRuntime.Runtime.Enviorment.AppDomain appdomain;

            public Adaptor()
            {
            }

            public Adaptor(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
            {
                this.appdomain = appdomain;
                this.instance = instance;
            }

            public ILTypeInstance ILInstance
            {
                get { return instance; }
                set { instance = value; }
            }

            public ILRuntime.Runtime.Enviorment.AppDomain AppDomain
            {
                get { return appdomain; }
                set { appdomain = value; }
            }


            IMethod mStartMethod;
            bool mStartMethodGot;

            void Start()
            {
                if (!mStartMethodGot)
                {
                    mStartMethod = instance.Type.GetMethod("Start", 0);
                    mStartMethodGot = true;
                }

                if (mStartMethod != null)
                {
                    appdomain.Invoke(mStartMethod, instance, null);
                }
            }

            #region 常用生命周期

            IMethod mOnInitMethod;
            bool mOnInitMethodGot;

            protected override void OnInit()
            {
                if (!mOnInitMethodGot)
                {
                    mOnInitMethod = instance.Type.GetMethod(nameof(OnInit), 0);
                    mOnInitMethodGot = true;
                }

                if (mOnInitMethod != null)
                {
                    appdomain.Invoke(mOnInitMethod, instance, null);
                }
            }

            IMethod mDoShowAnimationMethod;
            bool mDoShowAnimationMethodGot;

            override protected void DoShowAnimation()
            {
                if (!mDoShowAnimationMethodGot)
                {
                    mDoShowAnimationMethod = instance.Type.GetMethod(nameof(DoShowAnimation), 0);
                    mDoShowAnimationMethodGot = true;
                }

                if (mDoShowAnimationMethod != null)
                {
                    appdomain.Invoke(mDoShowAnimationMethod, instance, null);
                }
            }

            IMethod mDoHideAnimationMethod;
            bool mDoHideAnimationMethodGot;

            override protected void DoHideAnimation()
            {
                if (!mDoHideAnimationMethodGot)
                {
                    mDoHideAnimationMethod = instance.Type.GetMethod(nameof(DoHideAnimation), 0);
                    mDoHideAnimationMethodGot = true;
                }

                if (mDoHideAnimationMethod != null)
                {
                    appdomain.Invoke(mDoHideAnimationMethod, instance, null);
                }
            }

            IMethod mOnShownMethod;
            bool mOnShownMethodGot;

            override protected void OnShown()
            {
                if (!mOnShownMethodGot)
                {
                    mOnShownMethod = instance.Type.GetMethod(nameof(OnShown), 0);
                    mOnShownMethodGot = true;
                }

                if (mOnShownMethod != null)
                {
                    appdomain.Invoke(mOnShownMethod, instance, null);
                }
            }

            IMethod mOnHideMethod;
            bool mOnHideMethodGot;

            override protected void OnHide()
            {
                if (!mOnHideMethodGot)
                {
                    mOnHideMethod = instance.Type.GetMethod(nameof(OnHide), 0);
                    mOnHideMethodGot = true;
                }

                if (mOnHideMethod != null)
                {
                    appdomain.Invoke(mOnHideMethod, instance, null);
                }
            }

            #endregion

            IMethod mDisposeMethod;
            bool mDisposeMethodGot;
            public override void Dispose()
            {
                base.Dispose();
                if (!mDisposeMethodGot)
                {
                    mDisposeMethod = instance.Type.GetMethod(nameof(Dispose), 0);
                    mDisposeMethodGot = true;
                }

                if (mDisposeMethod != null)
                {
                    appdomain.Invoke(mDisposeMethod, instance, null);
                }
            }
            
            
            
            
            public override string ToString()
            {
                IMethod m = appdomain.ObjectType.GetMethod(nameof(ToString), 0);
                m = instance.Type.GetVirtualMethod(m);
                if (m == null || m is ILMethod)
                {
                    return instance.ToString();
                }
                else
                    return instance.Type.FullName;
            }
        }
    }
}

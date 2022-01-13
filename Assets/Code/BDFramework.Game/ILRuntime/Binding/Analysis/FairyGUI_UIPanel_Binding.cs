using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class FairyGUI_UIPanel_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(FairyGUI.UIPanel);
            args = new Type[]{};
            method = type.GetMethod("get_ui", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ui_0);
            args = new Type[]{};
            method = type.GetMethod("CreateUI", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateUI_1);

            field = type.GetField("packageName", flag);
            app.RegisterCLRFieldGetter(field, get_packageName_0);
            app.RegisterCLRFieldSetter(field, set_packageName_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_packageName_0, AssignFromStack_packageName_0);
            field = type.GetField("componentName", flag);
            app.RegisterCLRFieldGetter(field, get_componentName_1);
            app.RegisterCLRFieldSetter(field, set_componentName_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_componentName_1, AssignFromStack_componentName_1);


        }


        static StackObject* get_ui_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.UIPanel instance_of_this_method = (FairyGUI.UIPanel)typeof(FairyGUI.UIPanel).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ui;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateUI_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.UIPanel instance_of_this_method = (FairyGUI.UIPanel)typeof(FairyGUI.UIPanel).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CreateUI();

            return __ret;
        }


        static object get_packageName_0(ref object o)
        {
            return ((FairyGUI.UIPanel)o).packageName;
        }

        static StackObject* CopyToStack_packageName_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((FairyGUI.UIPanel)o).packageName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_packageName_0(ref object o, object v)
        {
            ((FairyGUI.UIPanel)o).packageName = (System.String)v;
        }

        static StackObject* AssignFromStack_packageName_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @packageName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((FairyGUI.UIPanel)o).packageName = @packageName;
            return ptr_of_this_method;
        }

        static object get_componentName_1(ref object o)
        {
            return ((FairyGUI.UIPanel)o).componentName;
        }

        static StackObject* CopyToStack_componentName_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((FairyGUI.UIPanel)o).componentName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_componentName_1(ref object o, object v)
        {
            ((FairyGUI.UIPanel)o).componentName = (System.String)v;
        }

        static StackObject* AssignFromStack_componentName_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @componentName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((FairyGUI.UIPanel)o).componentName = @componentName;
            return ptr_of_this_method;
        }



    }
}

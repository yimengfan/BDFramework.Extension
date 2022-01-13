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
    unsafe class FairyGUI_UIConfig_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(FairyGUI.UIConfig);

            field = type.GetField("defaultFont", flag);
            app.RegisterCLRFieldGetter(field, get_defaultFont_0);
            app.RegisterCLRFieldSetter(field, set_defaultFont_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_defaultFont_0, AssignFromStack_defaultFont_0);
            field = type.GetField("verticalScrollBar", flag);
            app.RegisterCLRFieldGetter(field, get_verticalScrollBar_1);
            app.RegisterCLRFieldSetter(field, set_verticalScrollBar_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_verticalScrollBar_1, AssignFromStack_verticalScrollBar_1);
            field = type.GetField("horizontalScrollBar", flag);
            app.RegisterCLRFieldGetter(field, get_horizontalScrollBar_2);
            app.RegisterCLRFieldSetter(field, set_horizontalScrollBar_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_horizontalScrollBar_2, AssignFromStack_horizontalScrollBar_2);
            field = type.GetField("popupMenu", flag);
            app.RegisterCLRFieldGetter(field, get_popupMenu_3);
            app.RegisterCLRFieldSetter(field, set_popupMenu_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_popupMenu_3, AssignFromStack_popupMenu_3);
            field = type.GetField("buttonSound", flag);
            app.RegisterCLRFieldGetter(field, get_buttonSound_4);
            app.RegisterCLRFieldSetter(field, set_buttonSound_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_buttonSound_4, AssignFromStack_buttonSound_4);


        }



        static object get_defaultFont_0(ref object o)
        {
            return FairyGUI.UIConfig.defaultFont;
        }

        static StackObject* CopyToStack_defaultFont_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = FairyGUI.UIConfig.defaultFont;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_defaultFont_0(ref object o, object v)
        {
            FairyGUI.UIConfig.defaultFont = (System.String)v;
        }

        static StackObject* AssignFromStack_defaultFont_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @defaultFont = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            FairyGUI.UIConfig.defaultFont = @defaultFont;
            return ptr_of_this_method;
        }

        static object get_verticalScrollBar_1(ref object o)
        {
            return FairyGUI.UIConfig.verticalScrollBar;
        }

        static StackObject* CopyToStack_verticalScrollBar_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = FairyGUI.UIConfig.verticalScrollBar;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_verticalScrollBar_1(ref object o, object v)
        {
            FairyGUI.UIConfig.verticalScrollBar = (System.String)v;
        }

        static StackObject* AssignFromStack_verticalScrollBar_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @verticalScrollBar = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            FairyGUI.UIConfig.verticalScrollBar = @verticalScrollBar;
            return ptr_of_this_method;
        }

        static object get_horizontalScrollBar_2(ref object o)
        {
            return FairyGUI.UIConfig.horizontalScrollBar;
        }

        static StackObject* CopyToStack_horizontalScrollBar_2(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = FairyGUI.UIConfig.horizontalScrollBar;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_horizontalScrollBar_2(ref object o, object v)
        {
            FairyGUI.UIConfig.horizontalScrollBar = (System.String)v;
        }

        static StackObject* AssignFromStack_horizontalScrollBar_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @horizontalScrollBar = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            FairyGUI.UIConfig.horizontalScrollBar = @horizontalScrollBar;
            return ptr_of_this_method;
        }

        static object get_popupMenu_3(ref object o)
        {
            return FairyGUI.UIConfig.popupMenu;
        }

        static StackObject* CopyToStack_popupMenu_3(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = FairyGUI.UIConfig.popupMenu;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_popupMenu_3(ref object o, object v)
        {
            FairyGUI.UIConfig.popupMenu = (System.String)v;
        }

        static StackObject* AssignFromStack_popupMenu_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @popupMenu = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            FairyGUI.UIConfig.popupMenu = @popupMenu;
            return ptr_of_this_method;
        }

        static object get_buttonSound_4(ref object o)
        {
            return FairyGUI.UIConfig.buttonSound;
        }

        static StackObject* CopyToStack_buttonSound_4(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = FairyGUI.UIConfig.buttonSound;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_buttonSound_4(ref object o, object v)
        {
            FairyGUI.UIConfig.buttonSound = (FairyGUI.NAudioClip)v;
        }

        static StackObject* AssignFromStack_buttonSound_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            FairyGUI.NAudioClip @buttonSound = (FairyGUI.NAudioClip)typeof(FairyGUI.NAudioClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            FairyGUI.UIConfig.buttonSound = @buttonSound;
            return ptr_of_this_method;
        }



    }
}

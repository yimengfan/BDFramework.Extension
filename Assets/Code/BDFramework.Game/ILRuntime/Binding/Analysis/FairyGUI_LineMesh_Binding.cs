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
    unsafe class FairyGUI_LineMesh_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(FairyGUI.LineMesh);

            field = type.GetField("lineWidthCurve", flag);
            app.RegisterCLRFieldGetter(field, get_lineWidthCurve_0);
            app.RegisterCLRFieldSetter(field, set_lineWidthCurve_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_lineWidthCurve_0, AssignFromStack_lineWidthCurve_0);
            field = type.GetField("roundEdge", flag);
            app.RegisterCLRFieldGetter(field, get_roundEdge_1);
            app.RegisterCLRFieldSetter(field, set_roundEdge_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_roundEdge_1, AssignFromStack_roundEdge_1);
            field = type.GetField("gradient", flag);
            app.RegisterCLRFieldGetter(field, get_gradient_2);
            app.RegisterCLRFieldSetter(field, set_gradient_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_gradient_2, AssignFromStack_gradient_2);
            field = type.GetField("path", flag);
            app.RegisterCLRFieldGetter(field, get_path_3);
            app.RegisterCLRFieldSetter(field, set_path_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_path_3, AssignFromStack_path_3);
            field = type.GetField("lineWidth", flag);
            app.RegisterCLRFieldGetter(field, get_lineWidth_4);
            app.RegisterCLRFieldSetter(field, set_lineWidth_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_lineWidth_4, AssignFromStack_lineWidth_4);
            field = type.GetField("fillEnd", flag);
            app.RegisterCLRFieldGetter(field, get_fillEnd_5);
            app.RegisterCLRFieldSetter(field, set_fillEnd_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_fillEnd_5, AssignFromStack_fillEnd_5);


        }



        static object get_lineWidthCurve_0(ref object o)
        {
            return ((FairyGUI.LineMesh)o).lineWidthCurve;
        }

        static StackObject* CopyToStack_lineWidthCurve_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((FairyGUI.LineMesh)o).lineWidthCurve;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_lineWidthCurve_0(ref object o, object v)
        {
            ((FairyGUI.LineMesh)o).lineWidthCurve = (UnityEngine.AnimationCurve)v;
        }

        static StackObject* AssignFromStack_lineWidthCurve_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.AnimationCurve @lineWidthCurve = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((FairyGUI.LineMesh)o).lineWidthCurve = @lineWidthCurve;
            return ptr_of_this_method;
        }

        static object get_roundEdge_1(ref object o)
        {
            return ((FairyGUI.LineMesh)o).roundEdge;
        }

        static StackObject* CopyToStack_roundEdge_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((FairyGUI.LineMesh)o).roundEdge;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_roundEdge_1(ref object o, object v)
        {
            ((FairyGUI.LineMesh)o).roundEdge = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_roundEdge_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @roundEdge = ptr_of_this_method->Value == 1;
            ((FairyGUI.LineMesh)o).roundEdge = @roundEdge;
            return ptr_of_this_method;
        }

        static object get_gradient_2(ref object o)
        {
            return ((FairyGUI.LineMesh)o).gradient;
        }

        static StackObject* CopyToStack_gradient_2(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((FairyGUI.LineMesh)o).gradient;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_gradient_2(ref object o, object v)
        {
            ((FairyGUI.LineMesh)o).gradient = (UnityEngine.Gradient)v;
        }

        static StackObject* AssignFromStack_gradient_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Gradient @gradient = (UnityEngine.Gradient)typeof(UnityEngine.Gradient).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((FairyGUI.LineMesh)o).gradient = @gradient;
            return ptr_of_this_method;
        }

        static object get_path_3(ref object o)
        {
            return ((FairyGUI.LineMesh)o).path;
        }

        static StackObject* CopyToStack_path_3(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((FairyGUI.LineMesh)o).path;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_path_3(ref object o, object v)
        {
            ((FairyGUI.LineMesh)o).path = (FairyGUI.GPath)v;
        }

        static StackObject* AssignFromStack_path_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            FairyGUI.GPath @path = (FairyGUI.GPath)typeof(FairyGUI.GPath).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((FairyGUI.LineMesh)o).path = @path;
            return ptr_of_this_method;
        }

        static object get_lineWidth_4(ref object o)
        {
            return ((FairyGUI.LineMesh)o).lineWidth;
        }

        static StackObject* CopyToStack_lineWidth_4(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((FairyGUI.LineMesh)o).lineWidth;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_lineWidth_4(ref object o, object v)
        {
            ((FairyGUI.LineMesh)o).lineWidth = (System.Single)v;
        }

        static StackObject* AssignFromStack_lineWidth_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @lineWidth = *(float*)&ptr_of_this_method->Value;
            ((FairyGUI.LineMesh)o).lineWidth = @lineWidth;
            return ptr_of_this_method;
        }

        static object get_fillEnd_5(ref object o)
        {
            return ((FairyGUI.LineMesh)o).fillEnd;
        }

        static StackObject* CopyToStack_fillEnd_5(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((FairyGUI.LineMesh)o).fillEnd;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_fillEnd_5(ref object o, object v)
        {
            ((FairyGUI.LineMesh)o).fillEnd = (System.Single)v;
        }

        static StackObject* AssignFromStack_fillEnd_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @fillEnd = *(float*)&ptr_of_this_method->Value;
            ((FairyGUI.LineMesh)o).fillEnd = @fillEnd;
            return ptr_of_this_method;
        }



    }
}

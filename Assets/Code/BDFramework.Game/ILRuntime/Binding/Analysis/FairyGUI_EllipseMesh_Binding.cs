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
    unsafe class FairyGUI_EllipseMesh_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(FairyGUI.EllipseMesh);

            field = type.GetField("startDegree", flag);
            app.RegisterCLRFieldGetter(field, get_startDegree_0);
            app.RegisterCLRFieldSetter(field, set_startDegree_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_startDegree_0, AssignFromStack_startDegree_0);
            field = type.GetField("endDegreee", flag);
            app.RegisterCLRFieldGetter(field, get_endDegreee_1);
            app.RegisterCLRFieldSetter(field, set_endDegreee_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_endDegreee_1, AssignFromStack_endDegreee_1);


        }



        static object get_startDegree_0(ref object o)
        {
            return ((FairyGUI.EllipseMesh)o).startDegree;
        }

        static StackObject* CopyToStack_startDegree_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((FairyGUI.EllipseMesh)o).startDegree;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_startDegree_0(ref object o, object v)
        {
            ((FairyGUI.EllipseMesh)o).startDegree = (System.Single)v;
        }

        static StackObject* AssignFromStack_startDegree_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @startDegree = *(float*)&ptr_of_this_method->Value;
            ((FairyGUI.EllipseMesh)o).startDegree = @startDegree;
            return ptr_of_this_method;
        }

        static object get_endDegreee_1(ref object o)
        {
            return ((FairyGUI.EllipseMesh)o).endDegreee;
        }

        static StackObject* CopyToStack_endDegreee_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((FairyGUI.EllipseMesh)o).endDegreee;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_endDegreee_1(ref object o, object v)
        {
            ((FairyGUI.EllipseMesh)o).endDegreee = (System.Single)v;
        }

        static StackObject* AssignFromStack_endDegreee_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @endDegreee = *(float*)&ptr_of_this_method->Value;
            ((FairyGUI.EllipseMesh)o).endDegreee = @endDegreee;
            return ptr_of_this_method;
        }



    }
}

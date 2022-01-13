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
    unsafe class FairyGUI_PolygonMesh_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(FairyGUI.PolygonMesh);

            field = type.GetField("usePercentPositions", flag);
            app.RegisterCLRFieldGetter(field, get_usePercentPositions_0);
            app.RegisterCLRFieldSetter(field, set_usePercentPositions_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_usePercentPositions_0, AssignFromStack_usePercentPositions_0);
            field = type.GetField("points", flag);
            app.RegisterCLRFieldGetter(field, get_points_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_points_1, null);
            field = type.GetField("texcoords", flag);
            app.RegisterCLRFieldGetter(field, get_texcoords_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_texcoords_2, null);


        }



        static object get_usePercentPositions_0(ref object o)
        {
            return ((FairyGUI.PolygonMesh)o).usePercentPositions;
        }

        static StackObject* CopyToStack_usePercentPositions_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((FairyGUI.PolygonMesh)o).usePercentPositions;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_usePercentPositions_0(ref object o, object v)
        {
            ((FairyGUI.PolygonMesh)o).usePercentPositions = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_usePercentPositions_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @usePercentPositions = ptr_of_this_method->Value == 1;
            ((FairyGUI.PolygonMesh)o).usePercentPositions = @usePercentPositions;
            return ptr_of_this_method;
        }

        static object get_points_1(ref object o)
        {
            return ((FairyGUI.PolygonMesh)o).points;
        }

        static StackObject* CopyToStack_points_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((FairyGUI.PolygonMesh)o).points;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_texcoords_2(ref object o)
        {
            return ((FairyGUI.PolygonMesh)o).texcoords;
        }

        static StackObject* CopyToStack_texcoords_2(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((FairyGUI.PolygonMesh)o).texcoords;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



    }
}

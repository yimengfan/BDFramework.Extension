using System;
using System.Collections.Generic;
using System.Reflection;

namespace ILRuntime.Runtime.Generated
{
    class CLRBindings
    {

//will auto register in unity
#if UNITY_5_3_OR_NEWER
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
#endif
        static private void RegisterBindingAction()
        {
            ILRuntime.Runtime.CLRBinding.CLRBindingUtils.RegisterBindingAction(Initialize);
        }

        internal static ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector2> s_UnityEngine_Vector2_Binding_Binder = null;
        internal static ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector3> s_UnityEngine_Vector3_Binding_Binder = null;
        internal static ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector4> s_UnityEngine_Vector4_Binding_Binder = null;
        internal static ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Quaternion> s_UnityEngine_Quaternion_Binding_Binder = null;

        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            FairyGUI_UIPackage_Binding.Register(app);
            FairyGUI_GObject_Binding.Register(app);
            FairyGUI_Window_Binding.Register(app);
            FairyGUI_GComponent_Binding.Register(app);
            FairyGUI_GList_Binding.Register(app);
            System_Int32_Binding.Register(app);
            FairyGUI_GButton_Binding.Register(app);
            UnityEngine_Vector2_Binding.Register(app);
            FairyGUI_GTweener_Binding.Register(app);
            FairyGUI_Transition_Binding.Register(app);
            System_Collections_Generic_List_1_Type_Binding.Register(app);
            System_Type_Binding.Register(app);
            System_Reflection_Assembly_Binding.Register(app);
            UnityEngine_Application_Binding.Register(app);
            System_Linq_Enumerable_Binding.Register(app);
            BDFramework_ILRuntimeHelper_Binding.Register(app);
            System_Reflection_MemberInfo_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_Type_Binding.Register(app);
            System_String_Binding.Register(app);
            BDebug_Binding.Register(app);
            BDFramework_Mgr_ManagerInstHelper_Binding.Register(app);
            System_Collections_Generic_List_1_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_List_1_ILTypeInstance_Binding_Enumerator_Binding.Register(app);
            System_IDisposable_Binding.Register(app);
            System_Activator_Binding.Register(app);
            BDFramework_BDLauncher_Binding.Register(app);
            FairyGUI_UIConfig_Binding.Register(app);
            FairyGUI_Stage_Binding.Register(app);
            FairyGUI_DisplayObject_Binding.Register(app);
            FairyGUI_EventListener_Binding.Register(app);
            FairyGUI_UIPanel_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_GComponent_Binding.Register(app);
            FairyGUI_EventContext_Binding.Register(app);
            FairyGUI_Controller_Binding.Register(app);
            FairyGUI_InputEvent_Binding.Register(app);
            FairyGUI_GGraph_Binding.Register(app);
            FairyGUI_NGraphics_Binding.Register(app);
            FairyGUI_EllipseMesh_Binding.Register(app);
            FairyGUI_PolygonMesh_Binding.Register(app);
            System_Collections_Generic_List_1_Vector2_Binding.Register(app);
            FairyGUI_VertexBuffer_Binding.Register(app);
            UnityEngine_AnimationCurve_Binding.Register(app);
            FairyGUI_LineMesh_Binding.Register(app);
            FairyGUI_GPathPoint_Binding.Register(app);
            UnityEngine_Vector3_Binding.Register(app);
            FairyGUI_GPath_Binding.Register(app);
            FairyGUI_GTween_Binding.Register(app);
            System_Enum_Binding.Register(app);
            UnityEngine_Color_Binding.Register(app);
            UnityEngine_Random_Binding.Register(app);
            FairyGUI_GTextField_Binding.Register(app);
            FairyGUI_GProgressBar_Binding.Register(app);
            FairyGUI_GMovieClip_Binding.Register(app);
            FairyGUI_PopupMenu_Binding.Register(app);
            UnityEngine_Debug_Binding.Register(app);
            UnityEngine_Rect_Binding.Register(app);
            FairyGUI_GRoot_Binding.Register(app);
            System_Nullable_1_Rect_Binding.Register(app);
            FairyGUI_Timers_Binding.Register(app);
            FairyGUI_TweenValue_Binding.Register(app);
            System_Object_Binding.Register(app);
            FairyGUI_DragDropManager_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_ILTypeInstance_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_KeyValuePair_2_Int32_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_IEnumerable_1_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_IEnumerator_1_ILTypeInstance_Binding.Register(app);
            System_Array_Binding.Register(app);
            System_Collections_IEnumerator_Binding.Register(app);
            System_Reflection_PropertyInfo_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_Object_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_List_1_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_List_1_Object_Binding.Register(app);
            System_Collections_Generic_List_1_Object_Binding.Register(app);
            BDFramework_Adaptor_ActionAdaptor_1_Object_Binding.Register(app);
            System_Collections_Generic_List_1_Object_Binding_Enumerator_Binding.Register(app);
            BDFramework_Adaptor_AActionAdaptor_Binding.Register(app);
            BDFramework_Adaptor_ActionAdaptor_1_ILTypeInstance_Binding.Register(app);
            System_Reflection_FieldInfo_Binding.Register(app);
            LitJson_JsonMapper_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding.Register(app);
            BDFramework_Core_Debugger_Debugger_NetworkServer_Binding.Register(app);
            UnityEngine_UI_Button_Binding.Register(app);
            UnityEngine_Events_UnityEventBase_Binding.Register(app);
            UnityEngine_Events_UnityEvent_Binding.Register(app);
            System_Action_Binding.Register(app);
            BDFramework_UFlux_IButton_Binding.Register(app);
            BDFramework_UFlux_IComponentOnClick_Binding.Register(app);
            UnityEngine_UI_Image_Binding.Register(app);
            UnityEngine_UI_Graphic_Binding.Register(app);
            UnityEngine_UI_Text_Binding.Register(app);
            UnityEngine_Transform_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_MemberInfo_Binding.Register(app);
            System_Collections_Generic_List_1_String_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Type_Dictionary_2_String_MemberInfo_Binding.Register(app);
            BDFramework_ResourceMgr_BResources_Binding.Register(app);
            UnityEngine_Component_Binding.Register(app);
            UnityEngine_Object_Binding.Register(app);
            System_Reflection_MethodBase_Binding.Register(app);
            ILRuntime_Mono_Cecil_MemberReference_Binding.Register(app);
            UnityEngine_Behaviour_Binding.Register(app);
            UnityEngine_GameObject_Binding.Register(app);
            ILRuntime_Runtime_Enviorment_AppDomain_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_IType_Binding.Register(app);
            ILRuntime_CLR_TypeSystem_IType_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Type_ILTypeInstance_Binding.Register(app);
            IEnumeratorTool_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Transform_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_List_1_MemberInfo_Binding.Register(app);
            System_Collections_Generic_List_1_MemberInfo_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_MemberInfo_Binding_ValueCollection_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_MemberInfo_Binding_ValueCollection_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_KeyValuePair_2_String_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_List_1_Transform_Binding.Register(app);
            UnityEngine_WaitForSeconds_Binding.Register(app);
            System_NotSupportedException_Binding.Register(app);
            System_Collections_Generic_List_1_Int32_Binding.Register(app);
            System_Collections_Generic_List_1_Int32_Binding_Enumerator_Binding.Register(app);
            System_Action_2_Int32_Int32_Binding.Register(app);
            System_Collections_Generic_List_1_Enum_Binding.Register(app);
            System_Collections_Generic_List_1_Enum_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_ILTypeInstance_Binding_ValueCollection_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_ILTypeInstance_Binding_ValueCollection_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_List_1_ILTypeInstance_Binding.Register(app);
            System_Reflection_MethodInfo_Binding.Register(app);
            System_Reflection_ParameterInfo_Binding.Register(app);
            BDFramework_Extension_FairyGUI_FairyGUILoader_Binding.Register(app);
            System_Char_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Type_MethodInfo_Binding.Register(app);

            ILRuntime.CLR.TypeSystem.CLRType __clrType = null;
            __clrType = (ILRuntime.CLR.TypeSystem.CLRType)app.GetType (typeof(UnityEngine.Vector2));
            s_UnityEngine_Vector2_Binding_Binder = __clrType.ValueTypeBinder as ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector2>;
            __clrType = (ILRuntime.CLR.TypeSystem.CLRType)app.GetType (typeof(UnityEngine.Vector3));
            s_UnityEngine_Vector3_Binding_Binder = __clrType.ValueTypeBinder as ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector3>;
            __clrType = (ILRuntime.CLR.TypeSystem.CLRType)app.GetType (typeof(UnityEngine.Vector4));
            s_UnityEngine_Vector4_Binding_Binder = __clrType.ValueTypeBinder as ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Vector4>;
            __clrType = (ILRuntime.CLR.TypeSystem.CLRType)app.GetType (typeof(UnityEngine.Quaternion));
            s_UnityEngine_Quaternion_Binding_Binder = __clrType.ValueTypeBinder as ILRuntime.Runtime.Enviorment.ValueTypeBinder<UnityEngine.Quaternion>;
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE ILRuntime Appdomain destroy
        /// </summary>
        public static void Shutdown(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            s_UnityEngine_Vector2_Binding_Binder = null;
            s_UnityEngine_Vector3_Binding_Binder = null;
            s_UnityEngine_Vector4_Binding_Binder = null;
            s_UnityEngine_Quaternion_Binding_Binder = null;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input/InputControl.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputControl : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControl"",
    ""maps"": [
        {
            ""name"": ""ActionMap"",
            ""id"": ""44699601-b9d4-47cb-ac6e-637db3a346f6"",
            ""actions"": [
                {
                    ""name"": ""MouseTap"",
                    ""type"": ""Button"",
                    ""id"": ""0eb83598-19ca-4920-a679-89a34ad42705"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Esc"",
                    ""type"": ""Button"",
                    ""id"": ""ceabbd9e-e54c-4f57-8a60-c5b48cbef4b4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Direction"",
                    ""type"": ""Value"",
                    ""id"": ""fe0fb871-f2dc-4a1a-ac3f-f07e0db1aa29"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b18033c6-4dad-41db-af3b-de2b2204a71f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseTap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47229027-d558-4b4c-a694-0f0e532b2680"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Esc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7c83f986-9ddf-4e73-b2ec-a48fb27a10f0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0a03e19e-138c-4c7f-836d-8e283c0dcee5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""afab80ed-a79e-46b9-8333-79aac5ee6e3d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fd47a609-1376-43bf-a2f5-0ff06e9dbab9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4e036509-2ce6-47b6-aa78-968d68c99757"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ActionMap
        m_ActionMap = asset.FindActionMap("ActionMap", throwIfNotFound: true);
        m_ActionMap_MouseTap = m_ActionMap.FindAction("MouseTap", throwIfNotFound: true);
        m_ActionMap_Esc = m_ActionMap.FindAction("Esc", throwIfNotFound: true);
        m_ActionMap_Direction = m_ActionMap.FindAction("Direction", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // ActionMap
    private readonly InputActionMap m_ActionMap;
    private IActionMapActions m_ActionMapActionsCallbackInterface;
    private readonly InputAction m_ActionMap_MouseTap;
    private readonly InputAction m_ActionMap_Esc;
    private readonly InputAction m_ActionMap_Direction;
    public struct ActionMapActions
    {
        private @InputControl m_Wrapper;
        public ActionMapActions(@InputControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseTap => m_Wrapper.m_ActionMap_MouseTap;
        public InputAction @Esc => m_Wrapper.m_ActionMap_Esc;
        public InputAction @Direction => m_Wrapper.m_ActionMap_Direction;
        public InputActionMap Get() { return m_Wrapper.m_ActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionMapActions set) { return set.Get(); }
        public void SetCallbacks(IActionMapActions instance)
        {
            if (m_Wrapper.m_ActionMapActionsCallbackInterface != null)
            {
                @MouseTap.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMouseTap;
                @MouseTap.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMouseTap;
                @MouseTap.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnMouseTap;
                @Esc.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnEsc;
                @Esc.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnEsc;
                @Esc.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnEsc;
                @Direction.started -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnDirection;
                @Direction.performed -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnDirection;
                @Direction.canceled -= m_Wrapper.m_ActionMapActionsCallbackInterface.OnDirection;
            }
            m_Wrapper.m_ActionMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MouseTap.started += instance.OnMouseTap;
                @MouseTap.performed += instance.OnMouseTap;
                @MouseTap.canceled += instance.OnMouseTap;
                @Esc.started += instance.OnEsc;
                @Esc.performed += instance.OnEsc;
                @Esc.canceled += instance.OnEsc;
                @Direction.started += instance.OnDirection;
                @Direction.performed += instance.OnDirection;
                @Direction.canceled += instance.OnDirection;
            }
        }
    }
    public ActionMapActions @ActionMap => new ActionMapActions(this);
    public interface IActionMapActions
    {
        void OnMouseTap(InputAction.CallbackContext context);
        void OnEsc(InputAction.CallbackContext context);
        void OnDirection(InputAction.CallbackContext context);
    }
}

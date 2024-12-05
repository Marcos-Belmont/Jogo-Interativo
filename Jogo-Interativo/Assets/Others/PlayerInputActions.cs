//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Others/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""NormalPlayer"",
            ""id"": ""82df7a11-2033-4e23-83fe-9bc0faa7c1eb"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""723870f1-9f2c-4e49-bda2-7cb1f321b52b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4f296836-2ff5-4190-b6de-a9731c2e3f64"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PausePlayer"",
            ""id"": ""24cf885c-42be-4395-80b0-716243b861ae"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""3a1d1bb7-a8c6-4344-85e5-2afdc72b5376"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2a645d55-6748-43d8-8d6f-cfb8f9edb9de"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4085bd2a-118c-4730-b78d-bc84de9e3e5f"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // NormalPlayer
        m_NormalPlayer = asset.FindActionMap("NormalPlayer", throwIfNotFound: true);
        m_NormalPlayer_Interact = m_NormalPlayer.FindAction("Interact", throwIfNotFound: true);
        // PausePlayer
        m_PausePlayer = asset.FindActionMap("PausePlayer", throwIfNotFound: true);
        m_PausePlayer_Pause = m_PausePlayer.FindAction("Pause", throwIfNotFound: true);
    }

    ~@PlayerInputActions()
    {
        UnityEngine.Debug.Assert(!m_NormalPlayer.enabled, "This will cause a leak and performance issues, PlayerInputActions.NormalPlayer.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_PausePlayer.enabled, "This will cause a leak and performance issues, PlayerInputActions.PausePlayer.Disable() has not been called.");
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

    // NormalPlayer
    private readonly InputActionMap m_NormalPlayer;
    private List<INormalPlayerActions> m_NormalPlayerActionsCallbackInterfaces = new List<INormalPlayerActions>();
    private readonly InputAction m_NormalPlayer_Interact;
    public struct NormalPlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public NormalPlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_NormalPlayer_Interact;
        public InputActionMap Get() { return m_Wrapper.m_NormalPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NormalPlayerActions set) { return set.Get(); }
        public void AddCallbacks(INormalPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_NormalPlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_NormalPlayerActionsCallbackInterfaces.Add(instance);
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
        }

        private void UnregisterCallbacks(INormalPlayerActions instance)
        {
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
        }

        public void RemoveCallbacks(INormalPlayerActions instance)
        {
            if (m_Wrapper.m_NormalPlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(INormalPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_NormalPlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_NormalPlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public NormalPlayerActions @NormalPlayer => new NormalPlayerActions(this);

    // PausePlayer
    private readonly InputActionMap m_PausePlayer;
    private List<IPausePlayerActions> m_PausePlayerActionsCallbackInterfaces = new List<IPausePlayerActions>();
    private readonly InputAction m_PausePlayer_Pause;
    public struct PausePlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PausePlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_PausePlayer_Pause;
        public InputActionMap Get() { return m_Wrapper.m_PausePlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PausePlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPausePlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PausePlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PausePlayerActionsCallbackInterfaces.Add(instance);
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
        }

        private void UnregisterCallbacks(IPausePlayerActions instance)
        {
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
        }

        public void RemoveCallbacks(IPausePlayerActions instance)
        {
            if (m_Wrapper.m_PausePlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPausePlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PausePlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PausePlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PausePlayerActions @PausePlayer => new PausePlayerActions(this);
    public interface INormalPlayerActions
    {
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IPausePlayerActions
    {
        void OnPause(InputAction.CallbackContext context);
    }
}

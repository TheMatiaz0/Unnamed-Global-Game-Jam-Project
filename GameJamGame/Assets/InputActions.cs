// GENERATED AUTOMATICALLY FROM 'Assets/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""b93745fe-e56d-4140-92b3-6f7a6ae66bec"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9b1d24c8-6094-48c5-92c4-21b4925b632f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""OpenPause"",
                    ""type"": ""Button"",
                    ""id"": ""d87fb3b1-7c6f-45c9-a847-c8da311276c3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6b5b8063-b44c-4063-af68-077c0371516f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchUI"",
                    ""type"": ""Button"",
                    ""id"": ""a4f77d4f-79d0-42fe-9c50-6e2e40aef500"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""A and D (Keyboard)"",
                    ""id"": ""23eeb108-b38a-41f4-8d9a-6f0eda17904e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""efd60c85-babe-41de-8067-26fa43f0d11a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""995c412e-65e3-4b53-9960-8b7f1ce485f7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows (Keyboard)"",
                    ""id"": ""de84d58e-739c-4d80-a960-2f03a358469c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e115c58f-a39e-46dc-996b-7b3ac3025c50"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ed0e92f5-655b-40bf-8597-cc6f5fdfc034"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Dragging (Controller)"",
                    ""id"": ""26d99fa0-90a3-409c-9343-30da59ca8d97"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0f632042-197c-4bb3-ad60-ef1df40bb8fe"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f8b09a59-f657-44d5-b2a9-0ebb28f5d02f"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""D-PAD (Controller)"",
                    ""id"": ""bfaad1cb-3c23-4229-aca6-421cc5e0ba53"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0939a03d-6d86-425b-91be-ea500c7c56e4"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""61d131d1-5e33-4b0b-8517-5b013edb443f"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e87f8fb9-e8a8-4ea1-80b6-a39a3dd15b70"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenPause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21ba13f8-34ac-4693-8532-a8a42c1b88a4"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenPause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da590ff6-3a13-48d5-81f0-a30d376ea66b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9dd27b01-d79f-45d7-adf3-01a20012e728"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20b40348-93b3-4046-a041-bcfdfddbad40"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3cb9b513-59e2-4ca8-8e38-fc2b0f4e669f"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchUI"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""adb40730-8682-44b2-ad4a-6676227ab1a1"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchUI"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PauseControls"",
            ""id"": ""f1ebc86c-b0e5-48bb-a018-e6e1c86a1c90"",
            ""actions"": [
                {
                    ""name"": ""UpDown"",
                    ""type"": ""Button"",
                    ""id"": ""8884158e-d144-4e70-aeaf-e6856933fe02"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""136e49e9-c872-4f9a-b2f8-10ecfec03de4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrows (Keyboard)"",
                    ""id"": ""27c3ddc0-443e-4164-a799-59740d5bc03e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""759d6480-c8a0-4fd0-9126-52d2fcd09713"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""74fe8565-fde9-49c7-9093-a5d313cf0fcf"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""W and S (Keyboard)"",
                    ""id"": ""e4850a1b-7f76-4984-a856-3479e61bcdc6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a9e457c2-1048-4911-ba46-9a5af92d54c0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f9e62352-5185-4ad7-b421-ff4c966735c0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""D-PAD (Controller)"",
                    ""id"": ""5018489d-7868-4713-aa68-1d8893d219a9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d8de7c16-42c7-4b89-bd8c-bb422cb81abb"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""11aaf2ae-7627-48a2-9124-bf26943d2592"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Dragging (Controller)"",
                    ""id"": ""3e922d9b-af8d-4b21-b7c2-cc7042969e6b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8c2b667e-1841-46c2-b578-6f3291696190"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""408c4c8e-353c-4976-a1a2-8df3462bcd98"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7a81723d-3905-4c22-990a-4c73efb660cc"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""506da105-31a9-4d35-8b25-a725e4761cc8"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a41421be-2683-43a8-9640-916bf524380b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""TutorialControls"",
            ""id"": ""ca8a0eb5-c838-433a-b953-e5b7c863bcf1"",
            ""actions"": [
                {
                    ""name"": ""SkipFull"",
                    ""type"": ""Button"",
                    ""id"": ""0c056db4-26c9-4687-a64e-93c9beb2adff"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SkipNext"",
                    ""type"": ""Button"",
                    ""id"": ""5eb4013e-afd7-477b-9e84-4a03019bd744"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a2486b42-e102-408c-99cc-1c94c545715d"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SkipFull"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40feccf3-c57b-402f-9860-73c91eb17d29"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SkipNext"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c40c3aec-c02c-47f0-b215-3e27a84d649d"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SkipNext"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_Move = m_PlayerControls.FindAction("Move", throwIfNotFound: true);
        m_PlayerControls_OpenPause = m_PlayerControls.FindAction("OpenPause", throwIfNotFound: true);
        m_PlayerControls_Jump = m_PlayerControls.FindAction("Jump", throwIfNotFound: true);
        m_PlayerControls_SwitchUI = m_PlayerControls.FindAction("SwitchUI", throwIfNotFound: true);
        // PauseControls
        m_PauseControls = asset.FindActionMap("PauseControls", throwIfNotFound: true);
        m_PauseControls_UpDown = m_PauseControls.FindAction("UpDown", throwIfNotFound: true);
        m_PauseControls_Click = m_PauseControls.FindAction("Click", throwIfNotFound: true);
        // TutorialControls
        m_TutorialControls = asset.FindActionMap("TutorialControls", throwIfNotFound: true);
        m_TutorialControls_SkipFull = m_TutorialControls.FindAction("SkipFull", throwIfNotFound: true);
        m_TutorialControls_SkipNext = m_TutorialControls.FindAction("SkipNext", throwIfNotFound: true);
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

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Move;
    private readonly InputAction m_PlayerControls_OpenPause;
    private readonly InputAction m_PlayerControls_Jump;
    private readonly InputAction m_PlayerControls_SwitchUI;
    public struct PlayerControlsActions
    {
        private @InputActions m_Wrapper;
        public PlayerControlsActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerControls_Move;
        public InputAction @OpenPause => m_Wrapper.m_PlayerControls_OpenPause;
        public InputAction @Jump => m_Wrapper.m_PlayerControls_Jump;
        public InputAction @SwitchUI => m_Wrapper.m_PlayerControls_SwitchUI;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @OpenPause.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnOpenPause;
                @OpenPause.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnOpenPause;
                @OpenPause.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnOpenPause;
                @Jump.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @SwitchUI.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwitchUI;
                @SwitchUI.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwitchUI;
                @SwitchUI.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwitchUI;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @OpenPause.started += instance.OnOpenPause;
                @OpenPause.performed += instance.OnOpenPause;
                @OpenPause.canceled += instance.OnOpenPause;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @SwitchUI.started += instance.OnSwitchUI;
                @SwitchUI.performed += instance.OnSwitchUI;
                @SwitchUI.canceled += instance.OnSwitchUI;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);

    // PauseControls
    private readonly InputActionMap m_PauseControls;
    private IPauseControlsActions m_PauseControlsActionsCallbackInterface;
    private readonly InputAction m_PauseControls_UpDown;
    private readonly InputAction m_PauseControls_Click;
    public struct PauseControlsActions
    {
        private @InputActions m_Wrapper;
        public PauseControlsActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @UpDown => m_Wrapper.m_PauseControls_UpDown;
        public InputAction @Click => m_Wrapper.m_PauseControls_Click;
        public InputActionMap Get() { return m_Wrapper.m_PauseControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPauseControlsActions instance)
        {
            if (m_Wrapper.m_PauseControlsActionsCallbackInterface != null)
            {
                @UpDown.started -= m_Wrapper.m_PauseControlsActionsCallbackInterface.OnUpDown;
                @UpDown.performed -= m_Wrapper.m_PauseControlsActionsCallbackInterface.OnUpDown;
                @UpDown.canceled -= m_Wrapper.m_PauseControlsActionsCallbackInterface.OnUpDown;
                @Click.started -= m_Wrapper.m_PauseControlsActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_PauseControlsActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_PauseControlsActionsCallbackInterface.OnClick;
            }
            m_Wrapper.m_PauseControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @UpDown.started += instance.OnUpDown;
                @UpDown.performed += instance.OnUpDown;
                @UpDown.canceled += instance.OnUpDown;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
            }
        }
    }
    public PauseControlsActions @PauseControls => new PauseControlsActions(this);

    // TutorialControls
    private readonly InputActionMap m_TutorialControls;
    private ITutorialControlsActions m_TutorialControlsActionsCallbackInterface;
    private readonly InputAction m_TutorialControls_SkipFull;
    private readonly InputAction m_TutorialControls_SkipNext;
    public struct TutorialControlsActions
    {
        private @InputActions m_Wrapper;
        public TutorialControlsActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @SkipFull => m_Wrapper.m_TutorialControls_SkipFull;
        public InputAction @SkipNext => m_Wrapper.m_TutorialControls_SkipNext;
        public InputActionMap Get() { return m_Wrapper.m_TutorialControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TutorialControlsActions set) { return set.Get(); }
        public void SetCallbacks(ITutorialControlsActions instance)
        {
            if (m_Wrapper.m_TutorialControlsActionsCallbackInterface != null)
            {
                @SkipFull.started -= m_Wrapper.m_TutorialControlsActionsCallbackInterface.OnSkipFull;
                @SkipFull.performed -= m_Wrapper.m_TutorialControlsActionsCallbackInterface.OnSkipFull;
                @SkipFull.canceled -= m_Wrapper.m_TutorialControlsActionsCallbackInterface.OnSkipFull;
                @SkipNext.started -= m_Wrapper.m_TutorialControlsActionsCallbackInterface.OnSkipNext;
                @SkipNext.performed -= m_Wrapper.m_TutorialControlsActionsCallbackInterface.OnSkipNext;
                @SkipNext.canceled -= m_Wrapper.m_TutorialControlsActionsCallbackInterface.OnSkipNext;
            }
            m_Wrapper.m_TutorialControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SkipFull.started += instance.OnSkipFull;
                @SkipFull.performed += instance.OnSkipFull;
                @SkipFull.canceled += instance.OnSkipFull;
                @SkipNext.started += instance.OnSkipNext;
                @SkipNext.performed += instance.OnSkipNext;
                @SkipNext.canceled += instance.OnSkipNext;
            }
        }
    }
    public TutorialControlsActions @TutorialControls => new TutorialControlsActions(this);
    public interface IPlayerControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnOpenPause(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSwitchUI(InputAction.CallbackContext context);
    }
    public interface IPauseControlsActions
    {
        void OnUpDown(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
    }
    public interface ITutorialControlsActions
    {
        void OnSkipFull(InputAction.CallbackContext context);
        void OnSkipNext(InputAction.CallbackContext context);
    }
}

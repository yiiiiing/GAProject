// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace myGame
{
    public class @InputActions : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""f51a437d-e0f8-4db2-a383-e35d0a2e9ea4"",
            ""actions"": [
                {
                    ""name"": ""PlayerMove"",
                    ""type"": ""Value"",
                    ""id"": ""8210f64d-c78e-4499-9e5c-eca8cbdde805"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraMove"",
                    ""type"": ""Value"",
                    ""id"": ""48d258b6-3237-4784-b797-1ab705c7ffde"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""e5db4e6e-90e5-4555-b541-bf37c05bf3f5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Defense"",
                    ""type"": ""Button"",
                    ""id"": ""fcb0d179-8b8e-49ca-b4ef-3defb799ba79"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Medicine"",
                    ""type"": ""Button"",
                    ""id"": ""741bd965-b7a1-4e5c-a60e-bef8378f54ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PickUp"",
                    ""type"": ""Button"",
                    ""id"": ""804e174b-a96e-471e-8394-20aed4498b1b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Enter"",
                    ""type"": ""Button"",
                    ""id"": ""1fa0c691-99a2-4d97-9ccd-f823aa5b9015"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""03636a1d-9b62-455a-9988-2d7a07a25d00"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""870d6c1e-d9f2-4766-94c8-6307df13b569"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Target"",
                    ""type"": ""Button"",
                    ""id"": ""0d997e97-cd90-4518-844a-fae08d1feb1a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Value"",
                    ""id"": ""99705107-e5c6-4d72-a8d6-c98ff5b4e4fd"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""64c243fc-c4dd-4f43-a207-9dfd46d62450"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""a5265881-9903-4bed-8555-6262d7ec7cb0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""65a8a838-0895-483b-a49b-2aac7332f88c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0aab35a6-69e5-42ed-b302-9ae5e5159c80"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cd692687-762f-422a-b2de-a7c0c8806df9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9c5b9959-4816-4f1e-abf8-604b7dc7ac62"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""89322a21-4158-4f0f-a184-f7d322420394"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4f65ec7-c5a1-4f8c-964c-642792a89c5f"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""871ef376-b1cd-41de-8455-93669e6f09ef"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d82716e-2a6c-4ae3-b84d-0b8fd6f7f1fc"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Defense"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""298fecf7-0780-4e52-b93c-e331d4dd2e3c"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Medicine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0586af33-616e-4c73-9318-05e089a2a82a"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9b7f271-daa2-4229-a312-c3ddaa7942c1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Enter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25862237-aab9-4e4a-b5d3-bf8118d090d9"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09cefa38-6d37-4e17-a06b-ed13298f2eec"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Target"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74111a11-d2a2-4955-b90c-cc78269cca61"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9b5482a-a21c-43a0-a465-7eaca7941048"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GameUI"",
            ""id"": ""272d58b7-f724-42d6-a5f2-7ee51dc99906"",
            ""actions"": [
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""99a9bfa7-9650-4a08-a389-a8a7f950526d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f0ea2d00-0b11-486c-9915-f7fe05b2cc5e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""8190ed43-c084-438e-ab6c-b896a2bd4f4e"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""06540219-cfb6-4ac1-a824-f590424da1bb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""c4d13b40-16c8-482a-b70d-0a1d09b6fe93"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDevicePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d9fa51ae-60eb-46a5-9003-6bc2d1c23c91"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDeviceRotation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""42980d4a-c669-4d08-9e2c-e47e6424950c"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""78cb524b-0b01-4823-b42c-40bde40c084d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4b096c75-3e19-4af5-814a-43f4d7ce20f3"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8307e8d-d6ca-4087-a52d-07126fed4c16"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""4cbdc081-ad97-446c-abff-7d240e58d201"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b7184bfe-20af-4baf-b14a-9186f394cffe"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6d05ad7b-7fc7-4c72-8aaf-b9c6d86f009d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""085af49f-1500-44b5-ba90-bbaa7df2b8de"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2f726ae1-98cd-4a95-bac8-67b6cb15e9c2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bd1b9245-2577-4d3e-920a-e00d51443a11"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6772e4c0-7b46-446b-bc91-f105c891b5c2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cf9bcb5b-e17b-4395-9e3a-444d9f764e5d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ca6529ca-83f7-448b-8414-29bef916588e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""03778e53-636e-4510-b83c-2f9abe68f7b2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f4fed30-8683-4f30-80f7-90d2e14c7152"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9112d5d-bf91-43f7-8240-2e438141d252"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3eaecf88-e489-4ea3-9dbc-ac3aedc46409"",
                    ""path"": ""<XRController>/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TrackedDevicePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba742547-bdd3-49be-8488-1c3193e5cdce"",
                    ""path"": ""<XRController>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TrackedDeviceRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b991bcdf-d151-4a7f-a2d6-6aadb2c0e13f"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3099c70-dd9f-4761-836c-011066b5e236"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // GamePlay
            m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
            m_GamePlay_PlayerMove = m_GamePlay.FindAction("PlayerMove", throwIfNotFound: true);
            m_GamePlay_CameraMove = m_GamePlay.FindAction("CameraMove", throwIfNotFound: true);
            m_GamePlay_Attack = m_GamePlay.FindAction("Attack", throwIfNotFound: true);
            m_GamePlay_Defense = m_GamePlay.FindAction("Defense", throwIfNotFound: true);
            m_GamePlay_Medicine = m_GamePlay.FindAction("Medicine", throwIfNotFound: true);
            m_GamePlay_PickUp = m_GamePlay.FindAction("PickUp", throwIfNotFound: true);
            m_GamePlay_Enter = m_GamePlay.FindAction("Enter", throwIfNotFound: true);
            m_GamePlay_Jump = m_GamePlay.FindAction("Jump", throwIfNotFound: true);
            m_GamePlay_Menu = m_GamePlay.FindAction("Menu", throwIfNotFound: true);
            m_GamePlay_Target = m_GamePlay.FindAction("Target", throwIfNotFound: true);
            m_GamePlay_Run = m_GamePlay.FindAction("Run", throwIfNotFound: true);
            // GameUI
            m_GameUI = asset.FindActionMap("GameUI", throwIfNotFound: true);
            m_GameUI_Menu = m_GameUI.FindAction("Menu", throwIfNotFound: true);
            m_GameUI_Click = m_GameUI.FindAction("Click", throwIfNotFound: true);
            m_GameUI_Navigate = m_GameUI.FindAction("Navigate", throwIfNotFound: true);
            m_GameUI_Submit = m_GameUI.FindAction("Submit", throwIfNotFound: true);
            m_GameUI_Cancel = m_GameUI.FindAction("Cancel", throwIfNotFound: true);
            m_GameUI_TrackedDevicePosition = m_GameUI.FindAction("TrackedDevicePosition", throwIfNotFound: true);
            m_GameUI_TrackedDeviceRotation = m_GameUI.FindAction("TrackedDeviceRotation", throwIfNotFound: true);
            m_GameUI_Point = m_GameUI.FindAction("Point", throwIfNotFound: true);
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

        // GamePlay
        private readonly InputActionMap m_GamePlay;
        private IGamePlayActions m_GamePlayActionsCallbackInterface;
        private readonly InputAction m_GamePlay_PlayerMove;
        private readonly InputAction m_GamePlay_CameraMove;
        private readonly InputAction m_GamePlay_Attack;
        private readonly InputAction m_GamePlay_Defense;
        private readonly InputAction m_GamePlay_Medicine;
        private readonly InputAction m_GamePlay_PickUp;
        private readonly InputAction m_GamePlay_Enter;
        private readonly InputAction m_GamePlay_Jump;
        private readonly InputAction m_GamePlay_Menu;
        private readonly InputAction m_GamePlay_Target;
        private readonly InputAction m_GamePlay_Run;
        public struct GamePlayActions
        {
            private @InputActions m_Wrapper;
            public GamePlayActions(@InputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @PlayerMove => m_Wrapper.m_GamePlay_PlayerMove;
            public InputAction @CameraMove => m_Wrapper.m_GamePlay_CameraMove;
            public InputAction @Attack => m_Wrapper.m_GamePlay_Attack;
            public InputAction @Defense => m_Wrapper.m_GamePlay_Defense;
            public InputAction @Medicine => m_Wrapper.m_GamePlay_Medicine;
            public InputAction @PickUp => m_Wrapper.m_GamePlay_PickUp;
            public InputAction @Enter => m_Wrapper.m_GamePlay_Enter;
            public InputAction @Jump => m_Wrapper.m_GamePlay_Jump;
            public InputAction @Menu => m_Wrapper.m_GamePlay_Menu;
            public InputAction @Target => m_Wrapper.m_GamePlay_Target;
            public InputAction @Run => m_Wrapper.m_GamePlay_Run;
            public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
            public void SetCallbacks(IGamePlayActions instance)
            {
                if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
                {
                    @PlayerMove.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPlayerMove;
                    @PlayerMove.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPlayerMove;
                    @PlayerMove.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPlayerMove;
                    @CameraMove.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCameraMove;
                    @CameraMove.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCameraMove;
                    @CameraMove.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCameraMove;
                    @Attack.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAttack;
                    @Attack.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAttack;
                    @Attack.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAttack;
                    @Defense.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnDefense;
                    @Defense.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnDefense;
                    @Defense.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnDefense;
                    @Medicine.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMedicine;
                    @Medicine.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMedicine;
                    @Medicine.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMedicine;
                    @PickUp.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPickUp;
                    @PickUp.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPickUp;
                    @PickUp.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPickUp;
                    @Enter.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnEnter;
                    @Enter.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnEnter;
                    @Enter.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnEnter;
                    @Jump.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                    @Menu.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMenu;
                    @Menu.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMenu;
                    @Menu.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMenu;
                    @Target.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTarget;
                    @Target.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTarget;
                    @Target.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTarget;
                    @Run.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRun;
                    @Run.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRun;
                    @Run.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRun;
                }
                m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @PlayerMove.started += instance.OnPlayerMove;
                    @PlayerMove.performed += instance.OnPlayerMove;
                    @PlayerMove.canceled += instance.OnPlayerMove;
                    @CameraMove.started += instance.OnCameraMove;
                    @CameraMove.performed += instance.OnCameraMove;
                    @CameraMove.canceled += instance.OnCameraMove;
                    @Attack.started += instance.OnAttack;
                    @Attack.performed += instance.OnAttack;
                    @Attack.canceled += instance.OnAttack;
                    @Defense.started += instance.OnDefense;
                    @Defense.performed += instance.OnDefense;
                    @Defense.canceled += instance.OnDefense;
                    @Medicine.started += instance.OnMedicine;
                    @Medicine.performed += instance.OnMedicine;
                    @Medicine.canceled += instance.OnMedicine;
                    @PickUp.started += instance.OnPickUp;
                    @PickUp.performed += instance.OnPickUp;
                    @PickUp.canceled += instance.OnPickUp;
                    @Enter.started += instance.OnEnter;
                    @Enter.performed += instance.OnEnter;
                    @Enter.canceled += instance.OnEnter;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @Menu.started += instance.OnMenu;
                    @Menu.performed += instance.OnMenu;
                    @Menu.canceled += instance.OnMenu;
                    @Target.started += instance.OnTarget;
                    @Target.performed += instance.OnTarget;
                    @Target.canceled += instance.OnTarget;
                    @Run.started += instance.OnRun;
                    @Run.performed += instance.OnRun;
                    @Run.canceled += instance.OnRun;
                }
            }
        }
        public GamePlayActions @GamePlay => new GamePlayActions(this);

        // GameUI
        private readonly InputActionMap m_GameUI;
        private IGameUIActions m_GameUIActionsCallbackInterface;
        private readonly InputAction m_GameUI_Menu;
        private readonly InputAction m_GameUI_Click;
        private readonly InputAction m_GameUI_Navigate;
        private readonly InputAction m_GameUI_Submit;
        private readonly InputAction m_GameUI_Cancel;
        private readonly InputAction m_GameUI_TrackedDevicePosition;
        private readonly InputAction m_GameUI_TrackedDeviceRotation;
        private readonly InputAction m_GameUI_Point;
        public struct GameUIActions
        {
            private @InputActions m_Wrapper;
            public GameUIActions(@InputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Menu => m_Wrapper.m_GameUI_Menu;
            public InputAction @Click => m_Wrapper.m_GameUI_Click;
            public InputAction @Navigate => m_Wrapper.m_GameUI_Navigate;
            public InputAction @Submit => m_Wrapper.m_GameUI_Submit;
            public InputAction @Cancel => m_Wrapper.m_GameUI_Cancel;
            public InputAction @TrackedDevicePosition => m_Wrapper.m_GameUI_TrackedDevicePosition;
            public InputAction @TrackedDeviceRotation => m_Wrapper.m_GameUI_TrackedDeviceRotation;
            public InputAction @Point => m_Wrapper.m_GameUI_Point;
            public InputActionMap Get() { return m_Wrapper.m_GameUI; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameUIActions set) { return set.Get(); }
            public void SetCallbacks(IGameUIActions instance)
            {
                if (m_Wrapper.m_GameUIActionsCallbackInterface != null)
                {
                    @Menu.started -= m_Wrapper.m_GameUIActionsCallbackInterface.OnMenu;
                    @Menu.performed -= m_Wrapper.m_GameUIActionsCallbackInterface.OnMenu;
                    @Menu.canceled -= m_Wrapper.m_GameUIActionsCallbackInterface.OnMenu;
                    @Click.started -= m_Wrapper.m_GameUIActionsCallbackInterface.OnClick;
                    @Click.performed -= m_Wrapper.m_GameUIActionsCallbackInterface.OnClick;
                    @Click.canceled -= m_Wrapper.m_GameUIActionsCallbackInterface.OnClick;
                    @Navigate.started -= m_Wrapper.m_GameUIActionsCallbackInterface.OnNavigate;
                    @Navigate.performed -= m_Wrapper.m_GameUIActionsCallbackInterface.OnNavigate;
                    @Navigate.canceled -= m_Wrapper.m_GameUIActionsCallbackInterface.OnNavigate;
                    @Submit.started -= m_Wrapper.m_GameUIActionsCallbackInterface.OnSubmit;
                    @Submit.performed -= m_Wrapper.m_GameUIActionsCallbackInterface.OnSubmit;
                    @Submit.canceled -= m_Wrapper.m_GameUIActionsCallbackInterface.OnSubmit;
                    @Cancel.started -= m_Wrapper.m_GameUIActionsCallbackInterface.OnCancel;
                    @Cancel.performed -= m_Wrapper.m_GameUIActionsCallbackInterface.OnCancel;
                    @Cancel.canceled -= m_Wrapper.m_GameUIActionsCallbackInterface.OnCancel;
                    @TrackedDevicePosition.started -= m_Wrapper.m_GameUIActionsCallbackInterface.OnTrackedDevicePosition;
                    @TrackedDevicePosition.performed -= m_Wrapper.m_GameUIActionsCallbackInterface.OnTrackedDevicePosition;
                    @TrackedDevicePosition.canceled -= m_Wrapper.m_GameUIActionsCallbackInterface.OnTrackedDevicePosition;
                    @TrackedDeviceRotation.started -= m_Wrapper.m_GameUIActionsCallbackInterface.OnTrackedDeviceRotation;
                    @TrackedDeviceRotation.performed -= m_Wrapper.m_GameUIActionsCallbackInterface.OnTrackedDeviceRotation;
                    @TrackedDeviceRotation.canceled -= m_Wrapper.m_GameUIActionsCallbackInterface.OnTrackedDeviceRotation;
                    @Point.started -= m_Wrapper.m_GameUIActionsCallbackInterface.OnPoint;
                    @Point.performed -= m_Wrapper.m_GameUIActionsCallbackInterface.OnPoint;
                    @Point.canceled -= m_Wrapper.m_GameUIActionsCallbackInterface.OnPoint;
                }
                m_Wrapper.m_GameUIActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Menu.started += instance.OnMenu;
                    @Menu.performed += instance.OnMenu;
                    @Menu.canceled += instance.OnMenu;
                    @Click.started += instance.OnClick;
                    @Click.performed += instance.OnClick;
                    @Click.canceled += instance.OnClick;
                    @Navigate.started += instance.OnNavigate;
                    @Navigate.performed += instance.OnNavigate;
                    @Navigate.canceled += instance.OnNavigate;
                    @Submit.started += instance.OnSubmit;
                    @Submit.performed += instance.OnSubmit;
                    @Submit.canceled += instance.OnSubmit;
                    @Cancel.started += instance.OnCancel;
                    @Cancel.performed += instance.OnCancel;
                    @Cancel.canceled += instance.OnCancel;
                    @TrackedDevicePosition.started += instance.OnTrackedDevicePosition;
                    @TrackedDevicePosition.performed += instance.OnTrackedDevicePosition;
                    @TrackedDevicePosition.canceled += instance.OnTrackedDevicePosition;
                    @TrackedDeviceRotation.started += instance.OnTrackedDeviceRotation;
                    @TrackedDeviceRotation.performed += instance.OnTrackedDeviceRotation;
                    @TrackedDeviceRotation.canceled += instance.OnTrackedDeviceRotation;
                    @Point.started += instance.OnPoint;
                    @Point.performed += instance.OnPoint;
                    @Point.canceled += instance.OnPoint;
                }
            }
        }
        public GameUIActions @GameUI => new GameUIActions(this);
        public interface IGamePlayActions
        {
            void OnPlayerMove(InputAction.CallbackContext context);
            void OnCameraMove(InputAction.CallbackContext context);
            void OnAttack(InputAction.CallbackContext context);
            void OnDefense(InputAction.CallbackContext context);
            void OnMedicine(InputAction.CallbackContext context);
            void OnPickUp(InputAction.CallbackContext context);
            void OnEnter(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnMenu(InputAction.CallbackContext context);
            void OnTarget(InputAction.CallbackContext context);
            void OnRun(InputAction.CallbackContext context);
        }
        public interface IGameUIActions
        {
            void OnMenu(InputAction.CallbackContext context);
            void OnClick(InputAction.CallbackContext context);
            void OnNavigate(InputAction.CallbackContext context);
            void OnSubmit(InputAction.CallbackContext context);
            void OnCancel(InputAction.CallbackContext context);
            void OnTrackedDevicePosition(InputAction.CallbackContext context);
            void OnTrackedDeviceRotation(InputAction.CallbackContext context);
            void OnPoint(InputAction.CallbackContext context);
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/MyInputSystem/Scripts/Runtime/Congifurations/InputActions.inputactions
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

namespace GoldSprite.UnityPlugins.MyInputSystem
{
    public partial class @InputActions: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""5be965ac-31c3-419f-b9df-6c3bc881c684"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""11f91349-8064-40bd-a4b1-268b8396e101"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveBoost"",
                    ""type"": ""Value"",
                    ""id"": ""93278c23-0c51-4eb8-9a4e-4f7ad10e8cb3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Value"",
                    ""id"": ""f1dbb9a2-08de-4233-a3d7-06f2c7327181"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""418f1fc6-9cb4-4e66-a86c-198e2eb13e93"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""UseItem"",
                    ""type"": ""Value"",
                    ""id"": ""89e30a6a-0387-4bc1-b5e5-fc6bc542641e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PickUPItem"",
                    ""type"": ""Value"",
                    ""id"": ""16c06d84-97ab-4fac-8d47-f32588d953d1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""FinalSkill"",
                    ""type"": ""Value"",
                    ""id"": ""baad1121-80c7-42b9-b8b6-c3b2bb3086ab"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ExchangeWeapon"",
                    ""type"": ""Value"",
                    ""id"": ""0165559e-e92b-4a56-bb7a-2a5ed3279e47"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""23db3036-5be3-4673-9eea-85cd900769d8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2e7fc328-ca1f-4a54-b27f-2aa9026981fd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3ccdab3b-dcbf-4833-acda-e8cd0702cd02"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""07d07d44-ad80-4cd7-833b-07ec9935fb42"",
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
                    ""id"": ""ea07dea2-fedf-4283-8113-e0142f53c6c6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d217ca89-d817-47b5-97b0-c02b95c4529a"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f131638c-7967-4e55-a4bf-931cd10a30d5"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4753e4fc-a898-46fb-b525-288c2ee5f275"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickUPItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4cf2911e-6cfd-4b5b-b786-db9fb522ae2a"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveBoost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4d2ea24-5022-4f47-81d8-eeddd081e5f4"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FinalSkill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5075255-ad20-43e5-9f41-ac226e0f02c3"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExchangeWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af2353d7-4114-43d7-b98d-825eb0135b0a"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UIPlay"",
            ""id"": ""ea699357-0f52-4a65-be22-dbf48a73bbdc"",
            ""actions"": [
                {
                    ""name"": ""Return"",
                    ""type"": ""Value"",
                    ""id"": ""53e4f7ff-2a13-4776-b352-0b49e37fbcd9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ce297bfe-21c8-47d0-87e1-1f9a05c0dd2a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Return"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""TestPlay"",
            ""id"": ""3e38b009-2c1e-4590-811a-296ca9a989bd"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""0c9b2d0b-289b-4d0a-963d-916b14926a5b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveBoost"",
                    ""type"": ""Value"",
                    ""id"": ""1726bac8-6921-4d42-9ca7-4559ce31b776"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Value"",
                    ""id"": ""12451553-1a5b-4bfe-90da-8510e95ac82b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SpecialAttack"",
                    ""type"": ""Value"",
                    ""id"": ""79575aae-1d23-46cd-9113-12b6219023ba"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Hurt"",
                    ""type"": ""Value"",
                    ""id"": ""518a0b6a-a06c-4d86-9b92-6cfa8e5fe5c0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""669f940c-0dab-40a2-a6e7-fa9c13e0a615"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fd794ce2-5836-44a7-a14f-e713ee60d653"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fcd583b3-f91b-466f-8ca7-54a751ac70e7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""860addb3-f899-46b9-8d61-b8b6fd4f36c9"",
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
                    ""id"": ""1847c8dd-52df-415e-9c08-fca5974b2193"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3d1e367e-d41d-4eff-bd36-b2da55fbef24"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a17acd6-77f9-49c9-9ec4-46ff4662a59c"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hurt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bccdd81f-7060-47c8-925c-9caf54c20e6e"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpecialAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9831200c-48cb-42d9-a984-0cc2b5431b60"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveBoost"",
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
            m_GamePlay_Move = m_GamePlay.FindAction("Move", throwIfNotFound: true);
            m_GamePlay_MoveBoost = m_GamePlay.FindAction("MoveBoost", throwIfNotFound: true);
            m_GamePlay_Attack = m_GamePlay.FindAction("Attack", throwIfNotFound: true);
            m_GamePlay_Jump = m_GamePlay.FindAction("Jump", throwIfNotFound: true);
            m_GamePlay_UseItem = m_GamePlay.FindAction("UseItem", throwIfNotFound: true);
            m_GamePlay_PickUPItem = m_GamePlay.FindAction("PickUPItem", throwIfNotFound: true);
            m_GamePlay_FinalSkill = m_GamePlay.FindAction("FinalSkill", throwIfNotFound: true);
            m_GamePlay_ExchangeWeapon = m_GamePlay.FindAction("ExchangeWeapon", throwIfNotFound: true);
            // UIPlay
            m_UIPlay = asset.FindActionMap("UIPlay", throwIfNotFound: true);
            m_UIPlay_Return = m_UIPlay.FindAction("Return", throwIfNotFound: true);
            // TestPlay
            m_TestPlay = asset.FindActionMap("TestPlay", throwIfNotFound: true);
            m_TestPlay_Move = m_TestPlay.FindAction("Move", throwIfNotFound: true);
            m_TestPlay_MoveBoost = m_TestPlay.FindAction("MoveBoost", throwIfNotFound: true);
            m_TestPlay_Attack = m_TestPlay.FindAction("Attack", throwIfNotFound: true);
            m_TestPlay_SpecialAttack = m_TestPlay.FindAction("SpecialAttack", throwIfNotFound: true);
            m_TestPlay_Hurt = m_TestPlay.FindAction("Hurt", throwIfNotFound: true);
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

        // GamePlay
        private readonly InputActionMap m_GamePlay;
        private List<IGamePlayActions> m_GamePlayActionsCallbackInterfaces = new List<IGamePlayActions>();
        private readonly InputAction m_GamePlay_Move;
        private readonly InputAction m_GamePlay_MoveBoost;
        private readonly InputAction m_GamePlay_Attack;
        private readonly InputAction m_GamePlay_Jump;
        private readonly InputAction m_GamePlay_UseItem;
        private readonly InputAction m_GamePlay_PickUPItem;
        private readonly InputAction m_GamePlay_FinalSkill;
        private readonly InputAction m_GamePlay_ExchangeWeapon;
        public struct GamePlayActions
        {
            private @InputActions m_Wrapper;
            public GamePlayActions(@InputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_GamePlay_Move;
            public InputAction @MoveBoost => m_Wrapper.m_GamePlay_MoveBoost;
            public InputAction @Attack => m_Wrapper.m_GamePlay_Attack;
            public InputAction @Jump => m_Wrapper.m_GamePlay_Jump;
            public InputAction @UseItem => m_Wrapper.m_GamePlay_UseItem;
            public InputAction @PickUPItem => m_Wrapper.m_GamePlay_PickUPItem;
            public InputAction @FinalSkill => m_Wrapper.m_GamePlay_FinalSkill;
            public InputAction @ExchangeWeapon => m_Wrapper.m_GamePlay_ExchangeWeapon;
            public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
            public void AddCallbacks(IGamePlayActions instance)
            {
                if (instance == null || m_Wrapper.m_GamePlayActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_GamePlayActionsCallbackInterfaces.Add(instance);
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MoveBoost.started += instance.OnMoveBoost;
                @MoveBoost.performed += instance.OnMoveBoost;
                @MoveBoost.canceled += instance.OnMoveBoost;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @UseItem.started += instance.OnUseItem;
                @UseItem.performed += instance.OnUseItem;
                @UseItem.canceled += instance.OnUseItem;
                @PickUPItem.started += instance.OnPickUPItem;
                @PickUPItem.performed += instance.OnPickUPItem;
                @PickUPItem.canceled += instance.OnPickUPItem;
                @FinalSkill.started += instance.OnFinalSkill;
                @FinalSkill.performed += instance.OnFinalSkill;
                @FinalSkill.canceled += instance.OnFinalSkill;
                @ExchangeWeapon.started += instance.OnExchangeWeapon;
                @ExchangeWeapon.performed += instance.OnExchangeWeapon;
                @ExchangeWeapon.canceled += instance.OnExchangeWeapon;
            }

            private void UnregisterCallbacks(IGamePlayActions instance)
            {
                @Move.started -= instance.OnMove;
                @Move.performed -= instance.OnMove;
                @Move.canceled -= instance.OnMove;
                @MoveBoost.started -= instance.OnMoveBoost;
                @MoveBoost.performed -= instance.OnMoveBoost;
                @MoveBoost.canceled -= instance.OnMoveBoost;
                @Attack.started -= instance.OnAttack;
                @Attack.performed -= instance.OnAttack;
                @Attack.canceled -= instance.OnAttack;
                @Jump.started -= instance.OnJump;
                @Jump.performed -= instance.OnJump;
                @Jump.canceled -= instance.OnJump;
                @UseItem.started -= instance.OnUseItem;
                @UseItem.performed -= instance.OnUseItem;
                @UseItem.canceled -= instance.OnUseItem;
                @PickUPItem.started -= instance.OnPickUPItem;
                @PickUPItem.performed -= instance.OnPickUPItem;
                @PickUPItem.canceled -= instance.OnPickUPItem;
                @FinalSkill.started -= instance.OnFinalSkill;
                @FinalSkill.performed -= instance.OnFinalSkill;
                @FinalSkill.canceled -= instance.OnFinalSkill;
                @ExchangeWeapon.started -= instance.OnExchangeWeapon;
                @ExchangeWeapon.performed -= instance.OnExchangeWeapon;
                @ExchangeWeapon.canceled -= instance.OnExchangeWeapon;
            }

            public void RemoveCallbacks(IGamePlayActions instance)
            {
                if (m_Wrapper.m_GamePlayActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IGamePlayActions instance)
            {
                foreach (var item in m_Wrapper.m_GamePlayActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_GamePlayActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public GamePlayActions @GamePlay => new GamePlayActions(this);

        // UIPlay
        private readonly InputActionMap m_UIPlay;
        private List<IUIPlayActions> m_UIPlayActionsCallbackInterfaces = new List<IUIPlayActions>();
        private readonly InputAction m_UIPlay_Return;
        public struct UIPlayActions
        {
            private @InputActions m_Wrapper;
            public UIPlayActions(@InputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Return => m_Wrapper.m_UIPlay_Return;
            public InputActionMap Get() { return m_Wrapper.m_UIPlay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(UIPlayActions set) { return set.Get(); }
            public void AddCallbacks(IUIPlayActions instance)
            {
                if (instance == null || m_Wrapper.m_UIPlayActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_UIPlayActionsCallbackInterfaces.Add(instance);
                @Return.started += instance.OnReturn;
                @Return.performed += instance.OnReturn;
                @Return.canceled += instance.OnReturn;
            }

            private void UnregisterCallbacks(IUIPlayActions instance)
            {
                @Return.started -= instance.OnReturn;
                @Return.performed -= instance.OnReturn;
                @Return.canceled -= instance.OnReturn;
            }

            public void RemoveCallbacks(IUIPlayActions instance)
            {
                if (m_Wrapper.m_UIPlayActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IUIPlayActions instance)
            {
                foreach (var item in m_Wrapper.m_UIPlayActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_UIPlayActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public UIPlayActions @UIPlay => new UIPlayActions(this);

        // TestPlay
        private readonly InputActionMap m_TestPlay;
        private List<ITestPlayActions> m_TestPlayActionsCallbackInterfaces = new List<ITestPlayActions>();
        private readonly InputAction m_TestPlay_Move;
        private readonly InputAction m_TestPlay_MoveBoost;
        private readonly InputAction m_TestPlay_Attack;
        private readonly InputAction m_TestPlay_SpecialAttack;
        private readonly InputAction m_TestPlay_Hurt;
        public struct TestPlayActions
        {
            private @InputActions m_Wrapper;
            public TestPlayActions(@InputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_TestPlay_Move;
            public InputAction @MoveBoost => m_Wrapper.m_TestPlay_MoveBoost;
            public InputAction @Attack => m_Wrapper.m_TestPlay_Attack;
            public InputAction @SpecialAttack => m_Wrapper.m_TestPlay_SpecialAttack;
            public InputAction @Hurt => m_Wrapper.m_TestPlay_Hurt;
            public InputActionMap Get() { return m_Wrapper.m_TestPlay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(TestPlayActions set) { return set.Get(); }
            public void AddCallbacks(ITestPlayActions instance)
            {
                if (instance == null || m_Wrapper.m_TestPlayActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_TestPlayActionsCallbackInterfaces.Add(instance);
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MoveBoost.started += instance.OnMoveBoost;
                @MoveBoost.performed += instance.OnMoveBoost;
                @MoveBoost.canceled += instance.OnMoveBoost;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @SpecialAttack.started += instance.OnSpecialAttack;
                @SpecialAttack.performed += instance.OnSpecialAttack;
                @SpecialAttack.canceled += instance.OnSpecialAttack;
                @Hurt.started += instance.OnHurt;
                @Hurt.performed += instance.OnHurt;
                @Hurt.canceled += instance.OnHurt;
            }

            private void UnregisterCallbacks(ITestPlayActions instance)
            {
                @Move.started -= instance.OnMove;
                @Move.performed -= instance.OnMove;
                @Move.canceled -= instance.OnMove;
                @MoveBoost.started -= instance.OnMoveBoost;
                @MoveBoost.performed -= instance.OnMoveBoost;
                @MoveBoost.canceled -= instance.OnMoveBoost;
                @Attack.started -= instance.OnAttack;
                @Attack.performed -= instance.OnAttack;
                @Attack.canceled -= instance.OnAttack;
                @SpecialAttack.started -= instance.OnSpecialAttack;
                @SpecialAttack.performed -= instance.OnSpecialAttack;
                @SpecialAttack.canceled -= instance.OnSpecialAttack;
                @Hurt.started -= instance.OnHurt;
                @Hurt.performed -= instance.OnHurt;
                @Hurt.canceled -= instance.OnHurt;
            }

            public void RemoveCallbacks(ITestPlayActions instance)
            {
                if (m_Wrapper.m_TestPlayActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(ITestPlayActions instance)
            {
                foreach (var item in m_Wrapper.m_TestPlayActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_TestPlayActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public TestPlayActions @TestPlay => new TestPlayActions(this);
        public interface IGamePlayActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnMoveBoost(InputAction.CallbackContext context);
            void OnAttack(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnUseItem(InputAction.CallbackContext context);
            void OnPickUPItem(InputAction.CallbackContext context);
            void OnFinalSkill(InputAction.CallbackContext context);
            void OnExchangeWeapon(InputAction.CallbackContext context);
        }
        public interface IUIPlayActions
        {
            void OnReturn(InputAction.CallbackContext context);
        }
        public interface ITestPlayActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnMoveBoost(InputAction.CallbackContext context);
            void OnAttack(InputAction.CallbackContext context);
            void OnSpecialAttack(InputAction.CallbackContext context);
            void OnHurt(InputAction.CallbackContext context);
        }
    }
}
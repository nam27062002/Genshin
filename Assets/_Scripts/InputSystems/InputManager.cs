using System;
using _Scripts.Singleton;
using UnityEngine;

namespace _Scripts.InputSystems
{
    public class InputManager : Singleton<InputManager>
    {
        public Vector2 MoveDirection => playerInputActions.Player.Move.ReadValue<Vector2>();
        private PlayerInputActions playerInputActions;
        
        protected override void Awake()
        {
            base.Awake();
            playerInputActions = new PlayerInputActions();
        }

        private void OnEnable()
        {
            playerInputActions.Enable();
        }

        private void OnDisable()
        {
            playerInputActions.Disable();
        }
    }
}

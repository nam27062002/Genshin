using System;
using _Scripts.InputSystems;
using UnityEngine;

namespace _Scripts.Player
{
    public class PlayerThirdCamMovement : MonoBehaviour
    {
        [SerializeField] private Transform orientation;
        private Vector2 moveDirection;

        private void Update()
        {
            GetInput();
        }

        private void GetInput()
        {
            moveDirection = InputManager.Instance.MoveDirection;
        }
        
    }
}

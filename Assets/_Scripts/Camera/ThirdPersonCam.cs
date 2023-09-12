using System;
using _Scripts.InputSystems;
using UnityEngine;

namespace _Scripts.Camera
{
    public class ThirdPersonCam : MonoBehaviour
    {
        [SerializeField] private Transform orientation;
        [SerializeField] private Transform playerObj;
        [SerializeField] private float rotationSpeed;
        private Vector2 moveDirection;
        private void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        
        private void Update()
        {
            GetInput();
            SetLookDirection();
        }
        
        private void GetInput()
        {
            moveDirection = InputManager.Instance.MoveDirection;
            Debug.Log(moveDirection);
        }

        private void SetLookDirection()
        {
            Vector3 viewDir = playerObj.position - new Vector3(transform.position.x,playerObj.position.y,transform.position.z);
            orientation.forward = viewDir.normalized;
            Vector3 inputDir = orientation.forward * moveDirection.y + orientation.right * moveDirection.x;
            if (inputDir != Vector3.zero)
            {
                playerObj.forward = Vector3.Slerp(playerObj.position,inputDir.normalized,Time.deltaTime * rotationSpeed);
            }
        }
        
    }
}

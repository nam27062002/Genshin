using System;
using Cinemachine;
using UnityEngine;

namespace _Scripts.Camera
{
    public class SetLookAtPlayer : MonoBehaviour
    {
        private const string TAG_PLAYER = "Player";
        private CinemachineVirtualCamera cinemachineVirtualCamera;
        
        private void Awake()
        {
            cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
        }

        private void Start()
        {
            SetLookAt();
        }

        private void SetLookAt()
        {
            Transform player = GameObject.FindWithTag(TAG_PLAYER).transform;
            cinemachineVirtualCamera.Follow = player;
            cinemachineVirtualCamera.LookAt = player;
        }
    }
}

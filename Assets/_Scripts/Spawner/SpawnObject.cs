using System;
using UnityEngine;

namespace _Scripts.Spawner
{
    public class SpawnObject : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private Vector3 positionSpawn;
        private void Start()
        {
            GameObject player = Instantiate(prefab,positionSpawn,Quaternion.identity,transform.parent);
        }
        
    }
}

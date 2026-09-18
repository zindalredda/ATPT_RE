using System;
using MisoL.Attributes;
using Unity.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Screen;

namespace Alice.MainMenu
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField] private GameObject alice;
        [SerializeField] [ReadonlyField] private Vector3 ogPos;
        [SerializeField] [ReadonlyField] private Vector3 mousePos;

        private void Awake()
        {
            ogPos = alice.transform.position;
        }

        private void FixedUpdate()
        {
            AliceMover();
        }
        
        private void AliceMover()
        {
            Vector3 pos = Mouse.current.position.ReadValue();
            mousePos = pos - new Vector3(width / 2, height / 2, 0);
            
            alice.transform.position = ogPos + (mousePos / 1000);
        }
    }
}

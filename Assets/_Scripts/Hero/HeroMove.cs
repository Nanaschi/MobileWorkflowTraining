using System;
using _Scripts.Infrastructure;
using _Scripts.Services.Input;
using UnityEngine;

namespace _Scripts.Hero
{
    public class HeroMove : MonoBehaviour
    {
        [SerializeField] private CharacterController characterController;
        private IInputService inputService;
        [SerializeField] private float _movementSpeed;

        private void Awake()
        {
            inputService = Game.InputService;
        }

        private void Update()
        {
            characterController.Move
            (_movementSpeed * 
             new Vector3(inputService.Axis.x, 0 , inputService.Axis.y)
             * Time.deltaTime);
        }
    }
}
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
        private Vector3 movementDirection;

        private void Awake()
        {
            inputService = Game.InputService;
        }

        private void Update()
        {

            
            
            characterController.Move(_movementSpeed * inputService.Axis * Time.deltaTime);


            transform.forward = inputService.Axis;
        }
    }
}
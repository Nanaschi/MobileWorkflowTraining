using _Scripts.StaticHelpers;
using UnityEngine;

namespace _Scripts.Services.Input
{
    class KeyboardInputService : IInputService
    {
        public Vector3 Axis =>
            new Vector3(UnityEngine.Input.GetAxis(Constants.Horizontal), 0,
                UnityEngine.Input.GetAxis(Constants.Vertical));

        public bool IsAttackButtonUp =>
            UnityEngine.Input.GetButtonDown(Constants.Button);
    }
}
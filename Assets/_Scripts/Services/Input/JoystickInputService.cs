using _Scripts.StaticHelpers;
using UnityEngine;

namespace _Scripts.Services.Input
{
    class JoystickInputService : IInputService
    {
        public Vector3 Axis =>
            new Vector3(SimpleInput.GetAxis(Constants.Horizontal), 0,
                SimpleInput.GetAxis(Constants.Vertical));

        public bool IsAttackButtonUp =>
            SimpleInput.GetButtonUp(Constants.Button);
    }
}
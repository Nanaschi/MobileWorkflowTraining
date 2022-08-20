using UnityEngine;

namespace _Scripts.Services.Input
{
    class InputService : IInputService
    {
        private const string Button = "Fire";
        private const string Vertical = "Vertical";
        private const string Horizontal = "Horizontal";

        public Vector3 Axis =>
            new Vector3(SimpleInput.GetAxis(Horizontal), 0,
                SimpleInput.GetAxis(Vertical));

        public bool IsAttackButtonUp =>
            SimpleInput.GetButtonUp(Button);
    }
}
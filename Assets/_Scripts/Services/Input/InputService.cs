using UnityEngine;

namespace _Scripts.Services.Input
{
    class InputService : IInputService
    {
        private const string Button = "Fire";
        private const string Vertical = "Vertical";
        private const string Horizontal = "Horizontal";

        public Vector2 Axis =>
            new Vector2(SimpleInput.GetAxis(Horizontal),
                SimpleInput.GetAxis(Vertical));

        public bool IsAttackButtonUp =>
            SimpleInput.GetButtonUp(Button);
    }
}
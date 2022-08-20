using _Scripts.Services.Input;

namespace _Scripts.Infrastructure
{
    internal class Game
    {
        public static IInputService InputService;


        public Game(bool joyStickControl)
        {
            if (joyStickControl) InputService = new JoystickInputService();
            else InputService = new KeyboardInputService();
        }
    }
}
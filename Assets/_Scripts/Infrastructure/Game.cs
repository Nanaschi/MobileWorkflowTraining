using _Scripts.Services.Input;

namespace _Scripts.Infrastructure
{
    internal class Game
    {
        public static IInputService InputService;


        public Game()
        {
            InputService = new InputService();
        }
    }
}
using UnityEngine;

namespace _Scripts.Infrastructure
{
    public class GameBootstrapper : MonoBehaviour
    {
        private Game _game;

        [SerializeField] private bool _joyStickControl;
        
        private void Awake()
        {
            _game = new Game(_joyStickControl);
            DontDestroyOnLoad(this);
        }
    }
}


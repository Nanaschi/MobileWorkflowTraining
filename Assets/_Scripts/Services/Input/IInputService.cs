using UnityEngine;

namespace _Scripts.Services.Input
{
    public interface IInputService
    {
        Vector3 Axis { get; }
        bool IsAttackButtonUp { get; }
    }
}
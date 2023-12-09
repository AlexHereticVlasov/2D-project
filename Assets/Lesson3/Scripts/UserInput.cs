using UnityEngine;

public sealed class UserInput : MonoBehaviour
{
    [SerializeField] private Throwing _throwing;

    private void Update()
    {
        if (Input.GetMouseButton(1))
            _throwing.CalculateSpeed();

        if (Input.GetMouseButtonUp(1))
            _throwing.TryThrow();
    }
}

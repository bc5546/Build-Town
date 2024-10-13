using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController
{
    private Camera camera;
    private void Awake()
    {
        camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput=value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 lookInput= value.Get<Vector2>();
        Vector2 worldPos=camera.ScreenToWorldPoint(lookInput);
        lookInput=(worldPos-(Vector2)transform.position).normalized;

        CallLookEvent(lookInput);
    }
}

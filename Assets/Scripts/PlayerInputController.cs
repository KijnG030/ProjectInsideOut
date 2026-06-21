using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    public Vector2 MovementInputVector {  get; private set; }
    public Vector2 LookInputVector { get; private set; }

    public bool SprintHeld { get; private set; }
    public bool JumpPressed { get; private set; }

    private void OnMove(InputValue inputValue)
    {
        MovementInputVector = inputValue.Get<Vector2>();
    }

    private void OnLook(InputValue value)
    {
        LookInputVector = value.Get<Vector2>();
    }

    private void OnSprint(InputValue value)
    {
        SprintHeld = value.isPressed;
    }

    private void OnJump()
    {
        JumpPressed = true;
    }

    public void ConsumeJump()
    {
        JumpPressed = false;
    }
}

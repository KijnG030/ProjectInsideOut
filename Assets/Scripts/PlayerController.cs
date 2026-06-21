using UnityEngine;
using UnityEngine.Windows;


public class PlayerController : MonoBehaviour
{
    private PlayerInputController input;
    private CharacterController controller;

    [SerializeField] private float movementSpeed;
    [SerializeField] private float sprintSpeed;
    [SerializeField] private float jumpHeight;
    [SerializeField] private float gravity = -9.81f;

    private float verticalVelocity;

    private void Awake()
    {
        input = GetComponent<PlayerInputController>();
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Move();

        JumpAndGravity();
    }

    private void Move()
    {
        float speed = input.SprintHeld ? sprintSpeed : movementSpeed;

        Vector3 moveDirection =
            transform.right * input.MovementInputVector.x +
            transform.forward * input.MovementInputVector.y;

        controller.Move(moveDirection * speed * Time.deltaTime);
    }

    private void JumpAndGravity()
    {
        if (controller.isGrounded && verticalVelocity < 0)
        {
            verticalVelocity = -2f;
        }

        if (input.JumpPressed && controller.isGrounded)
        {
            verticalVelocity = Mathf.Sqrt(jumpHeight * -2f * gravity);
            input.ConsumeJump();
        }

        verticalVelocity += gravity * Time.deltaTime;

        controller.Move(Vector3.up * verticalVelocity * Time.deltaTime);
    }
}


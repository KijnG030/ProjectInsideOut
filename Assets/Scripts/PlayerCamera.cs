using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private Transform playerBody;
    [SerializeField] private float sensitivity = 2f;

    private float xRotation = 0f;

    private PlayerInputController input;

    private void Awake()
    {
        input = playerBody.GetComponent<PlayerInputController>();
    }

    private void Update()
    {
        float mouseX = input.LookInputVector.x * sensitivity;
        float mouseY = input.LookInputVector.y * sensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerInputController playerInputController;
    [SerializeField] private float movementSpeed;

    private void Awake()
    {
        playerInputController = GetComponent<PlayerInputController>();
    }

    private void Update()
    {
        Vector3 postionChange = new Vector3(playerInputController.MovementInputVector.x, 0, playerInputController.MovementInputVector.y) * Time.deltaTime * movementSpeed;

        transform.position += postionChange;
    }
}

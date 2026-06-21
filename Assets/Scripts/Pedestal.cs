using UnityEngine;
using UnityEngine.SceneManagement;

public class Pedestal : MonoBehaviour, IInteractable
{
	[SerializeField] private string interactionMessage = "See solar system";
	public string InteractionMessage => interactionMessage;
	public bool Interact()
	{
		Debug.Log("Interacted with the pedestal to see the solar system.");
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		SceneManager.LoadScene("Solar System");
		return true;
	}
}

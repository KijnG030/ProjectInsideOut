using UnityEngine;
using UnityEngine.SceneManagement;

public class Pedestal : MonoBehaviour, IInteractable
{
	[SerializeField] private string interactionPrompt = "See solar system";
	public string InteractionPrompt => interactionPrompt;
	public bool Interact(Interactor interactor)
	{
		Debug.Log("Interacted with the pedestal to see the solar system.");
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		SceneManager.LoadScene("Solar System");
		return true;
	}
}

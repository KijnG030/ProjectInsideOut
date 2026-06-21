using UnityEngine;
using UnityEngine.SceneManagement;

public class Paper : MonoBehaviour, IInteractable
{
	[SerializeField] private string interactionMessage = "See solar system";
	public string InteractionMessage => interactionMessage;
	public bool Interact()
	{
		
		return true;
	}
}

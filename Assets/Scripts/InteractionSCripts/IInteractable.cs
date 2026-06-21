using UnityEngine;

public interface IInteractable
{
	public string InteractionMessage { get; }
	public bool Interact();
}

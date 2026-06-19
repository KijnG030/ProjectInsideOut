using UnityEngine;

public class QuizButton : MonoBehaviour, IInteractable
{
    [SerializeField] private string interactionPrompt = "See solar system";

    public string InteractionPrompt => interactionPrompt;

    public bool Interact(Interactor interactor)
    {

        return true;
    }
}

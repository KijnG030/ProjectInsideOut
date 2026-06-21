using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class QuizButton : MonoBehaviour, IInteractable
{
    [SerializeField] private string objectInteractMessage;
    [SerializeField] private int buttonId;
    [SerializeField] private QuizManager sequenceManager;

    public string InteractionMessage => objectInteractMessage;


    bool IInteractable.Interact()
    {
        sequenceManager.ButtonPressed(buttonId);
        return true;
    }
}

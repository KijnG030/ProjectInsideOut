using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    [SerializeField] private List<int> correctSequence;
    private List<int> currentSequence = new();

    [SerializeField] private List<GameObject> gameObjects;

    [Header("Audio")]
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip wrongSound;
    [SerializeField] private AudioClip sequenceCompleteSound;

    public void ButtonPressed(int buttonId)
    {
        currentSequence.Add(buttonId);

        int currentIndex = currentSequence.Count - 1;

        // Wrong button
        if (currentSequence[currentIndex] != correctSequence[currentIndex])
        {
            Debug.Log("Wrong sequence!");
            audioSource.PlayOneShot(wrongSound);
            currentSequence.Clear();
            return;
        }

        // Sequence complete
        if (currentSequence.Count == correctSequence.Count)
        {
            Debug.Log("Puzzle Solved!");
            audioSource.PlayOneShot(sequenceCompleteSound);
            currentSequence.Clear();
            OnPuzzleSolved();
        }
    }

    private void OnPuzzleSolved()
    {
        foreach (var item in gameObjects)
        {
            item.SetActive(true);
        }
    }
}

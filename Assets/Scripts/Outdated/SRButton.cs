using UnityEngine;
using UnityEngine.SceneManagement;

public class SRButton : MonoBehaviour
{
	public bool isStartButtonPressed = false;
	public void StartSim()
	{
		isStartButtonPressed = true;
	}

	public void Reset()
	{
		SceneManager.LoadScene("Solar System");
	}
}

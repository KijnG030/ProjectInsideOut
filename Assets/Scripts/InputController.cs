using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_InputField distanceInputField;
	[SerializeField] private TMPro.TMP_InputField speedInputField;
	[SerializeField] private TMPro.TMP_InputField sizeInputField;

	private void Start()
	{
		distanceInputField.onEndEdit.AddListener(OnDistanceChanged);
		speedInputField.onEndEdit.AddListener(OnSpeedChanged);
		sizeInputField.onEndEdit.AddListener(OnSizeChanged);
	}

	public void OnDistanceChanged(string value)
    {
        if (SolarSystemManager.Instance == null) return;

        if (float.TryParse(value, out float distance))
        {
            SolarSystemManager.Instance.selectablePlanet.SetDistance(distance);
			Debug.Log("Input detected: " + value);
		}
	}

	public void OnSpeedChanged(string value)
	{
		if (SolarSystemManager.Instance == null) return;

		if (float.TryParse(value, out float speed))
		{
			SolarSystemManager.Instance.selectablePlanet.SetSpeed(speed);
			Debug.Log("Input detected: " + value);
		}
	}

	public void OnSizeChanged(string value)
	{
		if (SolarSystemManager.Instance == null) return;

		if (float.TryParse(value, out float size))
		{
			SolarSystemManager.Instance.selectablePlanet.SetSize(size);
			Debug.Log("Input detected: " + value);
		}
	}
}

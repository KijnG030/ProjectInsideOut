using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UI : MonoBehaviour
{
    private Camera mainCam;
	[SerializeField] private TextMeshProUGUI promptText;
	[SerializeField] private GameObject UIObject;


	private void Start()
    {
        mainCam = Camera.main;
		UIObject.SetActive(false);
	}


	private void LateUpdate()
	{
		var rotation = mainCam.transform.rotation;
		transform.position = mainCam.transform.position;	
		transform.LookAt(transform.position + rotation * Vector3.forward, rotation * Vector3.up);
	}

	public bool IsDisplayed = false;

	public void SetUp(string UIpromptText)
	{
		promptText.text = UIpromptText;
		UIObject.SetActive(true);
		IsDisplayed = true;
	}

	public void Close()
	{
		UIObject.SetActive(false);
		IsDisplayed = false;
	}

}

using System.ComponentModel;
using UnityEngine;

public class SelectButton : MonoBehaviour
{
    public Planet planetToSelect;

	public void Select()
	{
		SolarSystemManager.Instance.SelectPlanet(planetToSelect);
	}
}

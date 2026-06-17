using UnityEngine;

public class PlanetCheck : MonoBehaviour
{
	public Planet planetToCheck;

	GameObject[] celestialMem;

	public bool mercuryIsOrb;
	public bool venusIsOrb;
	public bool earthIsOrb;
	public bool marsIsOrb;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
		Object.DontDestroyOnLoad(this);
		celestialMem = GameObject.FindGameObjectsWithTag("Celestials");
	}

    public bool PlanetChecker()
    {
		if (celestialMem == null || celestialMem.Length == 0) return false;

		foreach (GameObject obj in celestialMem)
		{
			Planet p = obj.GetComponent<Planet>();
			if (p != null && !p.isOrbiting)
			{
				return false; // Found one planet not ready, so return false immediately
			}
		}
		Debug.Log("All planets are orbiting!");
		return true; // All planets passed the check
	}

	public void Update()
	{
		if (planetToCheck.isOrbiting)
		{
			if (planetToCheck.name == "Mercury")
			{
				mercuryIsOrb = true;
			}
			if (planetToCheck.name == "Venus")
			{
				venusIsOrb = true;
			}
			if (planetToCheck.name == "Earth")
			{
				earthIsOrb = true;
			}
			if (planetToCheck.name == "Mars")
			{
				marsIsOrb = true;
			}
		}
	}
}

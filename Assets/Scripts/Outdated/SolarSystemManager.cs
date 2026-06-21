using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class SolarSystemManager : MonoBehaviour
{
    readonly float G = 100f; // Gravitational constant
    GameObject[] celestials;

    public static SolarSystemManager Instance { get; private set; }
    public Planet selectablePlanet;

	public PlanetCheck PlanetChecked;

	public SRButton sRBUtton;

	private bool hasInitialized = false;


	void Start()
    {
        celestials = GameObject.FindGameObjectsWithTag("Celestials");
	}

	private void Awake()
	{
		Instance = this;
	}

	private void FixedUpdate()
    {
		if (PlanetChecked.PlanetChecker())
		{
			Debug.Log("All Planets are Orbiting!");
			if (!hasInitialized)
			{
				InitialVelocity();
				hasInitialized = true;
			}

			Gravity();
		}
		
	}

    void Gravity()
    {
		foreach (GameObject a in celestials)
        {
			//Planet planetA = a.GetComponent<Planet>();
			//if (planetA == null || !planetA.isOrbiting)
			//{
			//	continue;
			//}

			foreach (GameObject b in celestials)
            {
                if (!a.Equals(b))
                {
                    float m1 = a.GetComponent<Rigidbody>().mass;
                    float m2 = b.GetComponent<Rigidbody>().mass;
                    float r = Vector3.Distance(a.transform.position, b.transform.position);

					a.GetComponent<Rigidbody>().AddForce((b.transform.position - a.transform.position).normalized * 
                        (G * (m1 * m2) / (r * r)));
				}
            }
		}
	}

    void InitialVelocity()
	{
		//Rigidbody rbA = p.GetComponent<Rigidbody>();
		//foreach (GameObject b in celestials)
		//{
		//	if (!p.Equals(b))
		//	{
		//		float m2 = b.GetComponent<Rigidbody>().mass;
		//		float r = Vector3.Distance(p.transform.position, b.transform.position);

		//		p.transform.LookAt(b.transform);
		//		// Orbital Velocity Formula: v = sqrt(G * M / r)
		//		rbA.linearVelocity = p.transform.right * Mathf.Sqrt(G * m2 / r);
		//	}
		//}



		foreach (GameObject a in celestials)
		{
			foreach (GameObject b in celestials)
			{
				if (!a.Equals(b))
				{
					float m2 = b.GetComponent<Rigidbody>().mass;
					float r = Vector3.Distance(a.transform.position, b.transform.position);
					a.transform.LookAt(b.transform);

					a.GetComponent<Rigidbody>().linearVelocity += a.transform.right * Mathf.Sqrt(G * (m2) / (r));
					Debug.Log("Linear velocity of " + a.name + ": " + a.GetComponent<Rigidbody>().linearVelocity);
				}
			}
		}
	}

    public void SelectPlanet(Planet planet)
    {
        selectablePlanet = planet;
		Debug.Log("Selected: " + planet.name);
	}
}

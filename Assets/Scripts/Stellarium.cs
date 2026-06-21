using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Stellarium : MonoBehaviour
{
    [SerializeField] private List<GameObject> planets;

    private bool sceneLoaded = false;

    private void Awake()
    {
        foreach (GameObject planet in planets)
        {
            planet.SetActive(false);
        }
    }

    private void Update()
    {
        foreach (GameObject planet in planets)
        {
            if (sceneLoaded)
            {
                return;
            }

            if (!planet.activeInHierarchy)
            {
                return;
            }
        }

        sceneLoaded = true;
        Debug.Log("Game Completed");
        SceneManager.LoadScene("EndScene");
    }
}


//public void ActivatePlanet(List<GameObject> list)
//{
//    foreach (GameObject planet in list)
//    {
//        if (!planet.activeInHierarchy)
//        {
//            planetsActive.Add(planet);
//            planet.SetActive(true);
//            Debug.Log(planetsActive);
//        }
//    }

//    if (planetsActive.Count == planets.Count)
//    {
//        Debug.Log("All planets activated!");
//        SceneManager.LoadScene("EndScene");
//    }
//}
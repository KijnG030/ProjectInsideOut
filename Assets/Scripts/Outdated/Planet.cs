using UnityEngine;

public class Planet : MonoBehaviour
{
    public bool isOrbiting = false; 

    public float speed;
    public float distance;
    public float size;

	[SerializeField] private float targetSpeed;
	[SerializeField] private float targetDistance;
	[SerializeField] private float targetSize;

    private void Update()
    {
        CheckIfTargetNumberCorrect();
	}

	public void SetSpeed(float setValue)
    {
        speed = setValue;
	}

    public void SetDistance(float setValue)
    {
        distance = setValue;
	}

    public void SetSize(float setValue)
    {
        size = setValue;
	}

    public void CheckIfTargetNumberCorrect()
    {
		if (speed == targetSpeed && distance == targetDistance && size == targetSize)
        {
            isOrbiting = true;
        }
        //else
        //{
        //    isOrbiting = false;
        //}
    }
}

using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private const float TopBound = 30;
    private const float LowerBound = -10;
    private const float SideBound = 30;

    private void Update()
    {
        if (transform.position.z > TopBound)
        {
            gameObject.SetActive(false);
        }
        else if (transform.position.z < LowerBound)
        {
            GameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x > SideBound)
        {
            GameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x < -SideBound)
        {
            GameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
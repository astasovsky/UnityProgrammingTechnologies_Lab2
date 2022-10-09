using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private const float TopBound = 30;
    private const float LowerBound = -10;

    private void Update()
    {
        if (transform.position.z > TopBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < LowerBound)
        {
            Destroy(gameObject);
            Debug.Log("Game over!");
        }
    }
}
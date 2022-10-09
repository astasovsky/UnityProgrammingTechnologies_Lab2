using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private const float TopBound = 30;
    private const float LowerBound = -10;

    private void Update()
    {
        if (transform.position.z is > TopBound or < LowerBound)
        {
            Destroy(gameObject);
        }
    }
}
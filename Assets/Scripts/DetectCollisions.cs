using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Food"))
        {
            GameManager.AddScore(5);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
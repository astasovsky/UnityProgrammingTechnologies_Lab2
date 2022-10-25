using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private AnimalHunger _animalHunger;

    private void Awake()
    {
        _animalHunger = GetComponent<AnimalHunger>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Food"))
        {
            _animalHunger.FeedAnimal(1);
            Destroy(other.gameObject);
        }
    }
}
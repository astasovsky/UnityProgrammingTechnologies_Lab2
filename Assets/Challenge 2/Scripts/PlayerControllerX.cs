using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField] private GameObject dogPrefab;

    private const float DogsSpawnRate = 0.5f;
    private float _nextDogTime;

    // Update is called once per frame
    private void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > _nextDogTime)
        {
            _nextDogTime = Time.time + DogsSpawnRate;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
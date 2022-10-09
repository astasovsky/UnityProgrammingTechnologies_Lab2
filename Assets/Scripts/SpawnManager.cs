using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;

    private const float SpawnRangeX = 10;
    private const float SpawnPosZ = 25;
    private const float StartDelay = 2;
    private const float SpawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), StartDelay, SpawnInterval);
    }

    private void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
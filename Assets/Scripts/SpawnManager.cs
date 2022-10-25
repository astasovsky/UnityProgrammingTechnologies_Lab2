using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;

    private const float SpawnRangeX = 10;
    private const float SpawnPosZ = 25;
    private const float StartDelay = 2;
    private const float SpawnInterval = 1.5f;

    private const float SideSpawnMinZ = 3;
    private const float SideSpawnMaxZ = 15;
    private const float SideSpawnX = 20;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), StartDelay, SpawnInterval);
    }

    private void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        SpawnLeftAnimal();
        SpawnRightAnimal();
    }

    private void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new(-SideSpawnX, 0, Random.Range(SideSpawnMinZ, SideSpawnMaxZ));
        Vector3 rotation = new(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }

    private void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new(SideSpawnX, 0, Random.Range(SideSpawnMinZ, SideSpawnMaxZ));
        Vector3 rotation = new(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
}
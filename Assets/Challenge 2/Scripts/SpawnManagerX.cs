using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private const float SpawnLimitXLeft = -22;
    private const float SpawnLimitXRight = 7;
    private const float SpawnPosY = 30;
    private const float StartDelay = 1.0f;

    // Start is called before the first frame update
    private void Start()
    {
        Invoke(nameof(SpawnRandomBall), StartDelay);
    }

    // Spawn random ball at random x position at top of play area
    private void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new(Random.Range(SpawnLimitXLeft, SpawnLimitXRight), SpawnPosY, 0);
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[0].transform.rotation);

        float spawnDelay = Random.Range(3f, 5);
        Invoke(nameof(SpawnRandomBall), spawnDelay);
    }
}
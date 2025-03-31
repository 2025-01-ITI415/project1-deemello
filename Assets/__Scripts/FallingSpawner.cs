using UnityEngine;

public class FallingSpawner : MonoBehaviour
{
    public GameObject[] fallingObjects;
    public float spawnInterval = 2f;
    public float spawnRangeX = 8f;

    void Start()
    {
        InvokeRepeating("SpawnFallingObject", 1f, spawnInterval);
    }

    void SpawnFallingObject()
    {
        float xPos = Random.Range(-spawnRangeX, spawnRangeX);
        int index = Random.Range(0, fallingObjects.Length);

        // ✅ Use the Spawner's actual Y position
        Vector3 spawnPosition = new Vector3(xPos, transform.position.y, 0f);

        Instantiate(fallingObjects[index], spawnPosition, Quaternion.identity);
    }
}

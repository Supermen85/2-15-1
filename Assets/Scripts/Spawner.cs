using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] SpawnPoint[] _spawnPoints;
    [SerializeField] private float _timeBetweenSpawns = 2f;

    private void Start()
    {
        StartCoroutine(SpawnInRandomSpawner());
    }

    private IEnumerator SpawnInRandomSpawner()
    {
        bool isRunning = true;

        while (isRunning)
        {
            int randomIndex = Random.Range(0, _spawnPoints.Length);

            _spawnPoints[randomIndex].Spawn();

            yield return new WaitForSeconds(_timeBetweenSpawns);
        }
    }
}
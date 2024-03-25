using System.Collections;
using UnityEngine;

public class SpawnerSelect : MonoBehaviour
{
    [SerializeField] Spawner[] _spawners;
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
            int randomIndex = Random.Range(0, _spawners.Length);

            _spawners[randomIndex].Spawn();

            yield return new WaitForSeconds(_timeBetweenSpawns);
        }
    }
}
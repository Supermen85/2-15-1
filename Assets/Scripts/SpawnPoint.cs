using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;

    private Vector3 _position;

    private void Awake()
    {
        _position = transform.position;    
    }

    public void Spawn()
    {
        float randomAngle = Random.Range(0, 360);
        Enemy enemy = Instantiate(_enemyPrefab, _position, Quaternion.Euler(0, randomAngle, 0));
    }
}
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
        Enemy enemy = Instantiate(_enemyPrefab, _position, Quaternion.identity);
        
        Vector3 direction = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
        
        enemy.SetDirection(direction);
    }
}
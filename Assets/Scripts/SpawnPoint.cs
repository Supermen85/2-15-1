using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private NPC _npc;

    private Vector3 _position;

    private void Awake()
    {
        _position = transform.position;    
    }

    public void Spawn()
    {
        Enemy enemy = Instantiate(_enemyPrefab, _position, Quaternion.identity);
        enemy.SetTarget(_npc);
        enemy.StartMovement();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;

    private Vector3 _position;

    void Start()
    {
        _position = gameObject.transform.position;    
    }

    public void Spawn()
    {
        float randomAngle = Random.Range(0, 360);
        Enemy enemy = Instantiate(_enemyPrefab, _position, Quaternion.Euler(0, randomAngle, 0));
    }
}
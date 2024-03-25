using UnityEngine;

[RequireComponent (typeof(Rigidbody))] 

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    
    private Vector3 _targetDirection;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();        
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        _rigidbody.velocity = new Vector3(_targetDirection.x * _speed, _rigidbody.velocity.y, _targetDirection.z * _speed);
    }

    public void SetDirection(Vector3 direction)
    {
        _targetDirection = direction;
    }
}

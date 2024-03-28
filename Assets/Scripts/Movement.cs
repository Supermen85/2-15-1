using UnityEngine;

[RequireComponent (typeof(Rigidbody))]

public class Movement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Transform _target;
    private float _speed;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void SetSpeed(float speed)
    {
        _speed = speed;
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }

    public void Move()
    {
        float directionX = _target.position.x - transform.position.x;
        float directionZ = _target.position.z - transform.position.z;

        Vector3 direction = new Vector3(directionX, 0f, directionZ).normalized;
        _rigidbody.velocity = new Vector3(direction.x * _speed, _rigidbody.velocity.y, direction.z * _speed);
    }
}

using UnityEngine;

[RequireComponent(typeof(Movement))]

public class NPC : MonoBehaviour
{
    [SerializeField] Transform[] _waypoints;
    [SerializeField] float _speed = 1f;

    private Movement _movement;

    private int _currentWaypointIndex;
    private float _minimumDistanceToWaypoint = 0.5f;

    private void Awake()
    {
        _currentWaypointIndex = Random.Range(0, _waypoints.Length);
 
        _movement = GetComponent<Movement>();

        _movement.SetSpeed(_speed);
        _movement.SetTarget(_waypoints[_currentWaypointIndex].transform);

        _movement.enabled = true;
    }

    private void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, _waypoints[_currentWaypointIndex].position) < _minimumDistanceToWaypoint)
        {
            ChangeWaypoint();
            _movement.SetTarget(_waypoints[_currentWaypointIndex].transform);
        }
    }

    public void ChangeWaypoint()
    {
        int newWaypointIndex = _currentWaypointIndex;

        while (newWaypointIndex == _currentWaypointIndex)
            newWaypointIndex = Random.Range(0, _waypoints.Length);

        _currentWaypointIndex = newWaypointIndex;
    }
}

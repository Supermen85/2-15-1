using UnityEngine;

[RequireComponent (typeof(Movement))] 

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;

    private Movement _movement;

    private void Awake()
    {
        _movement = GetComponent<Movement>();
        _movement.SetSpeed(_speed);
    }

    public void SetTarget(NPC npc)
    {
        _movement.SetTarget(npc.transform);
    }

    public void StartMovement()
    {
        _movement.enabled = true;
    }
}

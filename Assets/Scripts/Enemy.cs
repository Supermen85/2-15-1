using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Update()
    {
        Move();
    }

    public void Move()
    {
        float speed = 2f;

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void SetDirection(Vector3 direction)
    {

    }
}

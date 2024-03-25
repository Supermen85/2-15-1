using Unity.VisualScripting;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.GetComponent<Enemy>())
            Destroy(collider.gameObject);
    }
}

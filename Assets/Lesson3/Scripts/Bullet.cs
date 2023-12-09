using UnityEngine;
using UnityEngine.Events;

public sealed class Bullet : MonoBehaviour
{
    public UnityAction<Bullet> Collided;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collided?.Invoke(this);
        Destroy(gameObject);
    }
}

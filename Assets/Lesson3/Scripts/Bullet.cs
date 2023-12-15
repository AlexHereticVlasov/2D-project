using UnityEngine;
using UnityEngine.Events;

public sealed class Bullet : MonoBehaviour
{
    
    public UnityAction<Bullet> Collided;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.transform.TryGetComponent(out Enemy enemy))
        //{
        //    enemy.TakeDamage(5);
        //}

        var colliders = Physics2D.OverlapCircleAll(transform.position, 1);

        foreach (var collider in colliders)
        {
            if (collider.transform.TryGetComponent(out Enemy enemy))
            {
                enemy.TakeDamage(5);
            }
        }


        Collided?.Invoke(this);
        Destroy(gameObject);
    }
}

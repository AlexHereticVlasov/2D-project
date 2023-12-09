using UnityEngine;

public sealed class BulletViev : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private TrailRenderer _trail;

    private void OnEnable()
    {
        _bullet.Collided += OnCollided;   
    }

    private void OnCollided(Bullet bullet)
    {
        _trail.transform.SetParent(null);
    }

    private void OnDisable()
    {
        _bullet.Collided -= OnCollided;
    }
}

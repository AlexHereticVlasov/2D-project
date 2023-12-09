using UnityEngine;

public sealed class EffectSpawner : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private ParticleSystem _particles;

    private void OnEnable() => _bullet.Collided += OnCollided;

    private void OnDisable() => _bullet.Collided -= OnCollided;

    private void OnCollided(Bullet bullet)
    {
        var particles = Instantiate(_particles, bullet.transform.position, Quaternion.identity);
        Destroy(particles, 5f);
    }
}

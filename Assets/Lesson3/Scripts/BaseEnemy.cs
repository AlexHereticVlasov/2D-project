using System;
using UnityEngine;
using UnityEngine.Events;

public abstract class BaseEnemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] public int _health = 5;

    public event UnityAction<BaseEnemy> Death;

    private void Update() => transform.Translate(Vector3.left * _speed * Time.deltaTime);

    public void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
            Die();
    }

    public void TakeDamage() => TakeDamage(50);

    public abstract void Say(string sentense);

    private void Die()
    {
        Death?.Invoke(this);
        Destroy(gameObject);
    }

    public void Init(EnemyData data)
    {
        _health = data.Healt;
        _speed = data.Speed;
    }
}


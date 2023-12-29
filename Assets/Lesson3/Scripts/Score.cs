using UnityEngine;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    [SerializeField] private EnemyFabric[] _enemyFabrics;

    private int _value;

    public event UnityAction<int> ValueChanged;

    private void OnEnable()
    {
        foreach (var fabric in _enemyFabrics)
        {
            fabric.EnemySpawned += OnEnemySpawned;
        }
    }

    private void OnDisable()
    {
        foreach (var fabric in _enemyFabrics)
        {
            fabric.EnemySpawned -= OnEnemySpawned;
        }
    }

    private void OnEnemySpawned(BaseEnemy enemy)
    {
        enemy.Death += OnDeath;
    }

    private void OnDeath(BaseEnemy enemy)
    {
        enemy.Death -= OnDeath;

        _value++;
        ValueChanged?.Invoke(_value);
    }
}

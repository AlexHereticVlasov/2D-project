using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyFabric : MonoBehaviour
{
    [SerializeField] private Enemy _groundEnemyTemplate;
    [SerializeField] private Enemy _flyingEnemyTemplate;

    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private Transform _topSpawnPosition;

    [SerializeField] private float _minRate;
    [SerializeField] private float _maxRate;
    [SerializeField] private float _currentRate;

    public event UnityAction<Enemy> EnemySpawned;

    private void Update()
    {
        _currentRate -= Time.deltaTime;

        if (_currentRate <= 0)
        {
            _currentRate = Random.Range(_minRate, _maxRate);

            var enemy = Instantiate(_groundEnemyTemplate, _spawnPosition.position, Quaternion.identity);
            EnemySpawned?.Invoke(enemy);

            var flyingEnemy = Instantiate(_flyingEnemyTemplate, _spawnPosition.position, Quaternion.identity);
            EnemySpawned?.Invoke(flyingEnemy);
        }
    }
}

public class Timer
{ 
    
}

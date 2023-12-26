using UnityEngine;
using UnityEngine.Events;

public class EnemyFabric : MonoBehaviour
{
    [SerializeField] private Enemy _groundEnemyTemplate;
    [SerializeField] private Enemy _flyingEnemyTemplate;

    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private Transform _topSpawnPosition;


    [SerializeField] private EnemyData[] _enemyDatas;

    private Timer _timer;

    public event UnityAction<Enemy> EnemySpawned;

    private void Awake() => _timer = new Timer(2, 5);

    private void OnEnable() => _timer.TimeIsOver += OnTimeIsOver;

    private void Update() => _timer.Update();

    private void OnDisable() => _timer.TimeIsOver -= OnTimeIsOver;

    private void OnTimeIsOver()
    {
        var enemy = Instantiate(_groundEnemyTemplate, _spawnPosition.position, Quaternion.identity);
        EnemySpawned?.Invoke(enemy);

        enemy.Init(_enemyDatas[Random.Range(0, _enemyDatas.Length)]);

        var flyingEnemy = Instantiate(_flyingEnemyTemplate, _spawnPosition.position, Quaternion.identity);
        EnemySpawned?.Invoke(flyingEnemy);

        flyingEnemy.Init(_enemyDatas[Random.Range(0, _enemyDatas.Length)]);
    }
}

public class Timer
{
    [SerializeField] private float _minRate;
    [SerializeField] private float _maxRate;
    [SerializeField] private float _currentRate;

    public event UnityAction TimeIsOver;

    public Timer(float minRate, float maxRate)
    {
        _minRate = minRate;
        _maxRate = maxRate;
        _currentRate = Random.Range(_minRate, _maxRate);
    }

    public void Update()
    {
        _currentRate -= Time.deltaTime;

        if (_currentRate <= 0)
        {
            TimeIsOver?.Invoke();
            _currentRate = Random.Range(_minRate, _maxRate);
        }
    }
}

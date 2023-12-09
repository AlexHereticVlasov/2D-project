using System.Collections;
using UnityEngine;

public sealed class Throwing : MonoBehaviour
{
    [SerializeField] private float _power = 10;
    [SerializeField] private Transform _point;
    [SerializeField] private Bullet _template;
    [SerializeField] private TrajectoryRenderer _trajectoryRenderer;

    private Vector3 _speed;
    private bool _canShoot = true;

    public void TryThrow()
    {
        if (_canShoot)
            Throw();
    }

    public void CalculateSpeed()
    {
        if (_canShoot == false) return;

        var target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.z = 0;
        _speed = (target - _point.position) * _power;
        _trajectoryRenderer.Draw(_point.position, _speed);
    }

    private void Throw()
    {
        Rigidbody2D bullet = Instantiate(_template, _point.position, Quaternion.identity).GetComponent<Rigidbody2D>();
        bullet.velocity = _speed;
        _trajectoryRenderer.Hide();
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        Debug.Log("Cant Shoot");
        _canShoot = false;
        yield return new WaitForSeconds(2);
        _canShoot = true;
        Debug.Log("Can Shoot!");
        
    }
}

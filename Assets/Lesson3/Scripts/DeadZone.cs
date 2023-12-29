using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.TryGetComponent(out BaseEnemy enemy))
        {
            Destroy(enemy.gameObject);
            //SendMessage
        }
    }
}

public sealed class GameOver : MonoBehaviour
{
    [SerializeField] private DeadZone _deadZone;

    private int _livesAmount = 5;

    private void OnEnable()
    {

    }
}

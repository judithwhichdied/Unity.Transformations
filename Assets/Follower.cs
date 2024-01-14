
using System.Runtime.CompilerServices;
using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.LookAt(_target.position);

        var direction = (_target.position - transform.position).normalized;

        transform.Translate(direction * _speed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public abstract class Transport : MonoBehaviour
{
    [SerializeField] protected float _speed;
    [SerializeField] protected float _turningSpeed;
    [SerializeField] protected float _health;
    protected IControllable _controller;
    protected Player _player;

    [Inject]
    public void Construct(IControllable controller, Player player)
    {
        _controller = controller;
        _player = player;
    }
}

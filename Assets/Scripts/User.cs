using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class User : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _turningSpeed;
    private IControlable _controlable;
    private PhotonView _photonView;

    public void Initialize(IControlable controlable, PhotonView photonView)
    {
        _photonView = photonView;
        _controlable = controlable;
    }

    private void FixedUpdate()
    {
        if (!_photonView.IsMine) return; //PUN has an ownership concept that defines who can control and destroy each PhotonView. With this property, one player will not be able to control and change the movement of another player

        _controlable.Controller(_speed, _turningSpeed);
    }
}

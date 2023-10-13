using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class User : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _turningSpeed;
    private PhotonView _photonView;

    public void Intialize()
    {
        _photonView = GetComponent<PhotonView>();
    }

    private void FixedUpdate()
    {
        if (!_photonView.IsMine) return; //PUN has an ownership concept that defines who can control and destroy each PhotonView. With this property, one player will not be able to control and change the movement of another player


        transform.Rotate(0, Input.GetAxis("Horizontal") * _turningSpeed * Time.deltaTime, 0);
        transform.Translate(0,0, Input.GetAxis("Vertical") * _speed * Time.deltaTime);
    }
}

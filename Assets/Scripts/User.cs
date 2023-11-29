using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class User : MonoBehaviour, IPunObservable
{
    [SerializeField] private float _speed;
    [SerializeField] private float _turningSpeed;
    [SerializeField] private TextMeshPro _nickNameText;
    private IControlable _controlable;
    private PhotonView _photonView;
    private UserMovement _userMovement;

    private Transform _transform;

    private void Start()
    {
        _photonView = GetComponent<PhotonView>();
        _transform = GetComponent<Transform>();
        _userMovement = GetComponent<UserMovement>();
        _controlable = new KeyboardController(_userMovement);

        _nickNameText.SetText(_photonView.Owner.NickName);

        if (!_photonView.IsMine)
        {
            _nickNameText.color = Color.green;
        }
    }

    private void FixedUpdate()
    {
        if (!_photonView.IsMine) return; //PUN has an ownership concept that defines who can control and destroy each PhotonView. With this property, one player will not be able to control and change the movement of another player   

        _controlable.Controller();
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {

    }
}

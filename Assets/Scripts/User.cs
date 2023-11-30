using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class User : MonoBehaviour, IPunObservable
{
    [SerializeField] private float _speed;
    [SerializeField] private float _turningSpeed;

    [SerializeField] private TextMeshProUGUI _nickNameText;
    [SerializeField] private GameObject _nicknameField;

    private IControlable _controlable;
    private PhotonView _photonView;
    private UserMovement _userMovement;
    private Camera _camera;

    private void Start()
    {
        _photonView = GetComponent<PhotonView>();
        _userMovement = GetComponent<UserMovement>();
        _controlable = new KeyboardController(_userMovement);
        _camera = Camera.main;

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

    private void LateUpdate()
    {
        _nicknameField.transform.LookAt(new Vector3(transform.position.x, _camera.transform.position.y, _camera.transform.position.z));
        _nicknameField.transform.Rotate(0, 180, 0);
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {

    }
}

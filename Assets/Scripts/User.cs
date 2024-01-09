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

    public GameObject InformationUserPanel;

    private IControlable _controlable;
    private PhotonView _photonView;
    public PhotonView PhotonView { get => _photonView;}
    private UserMovement _userMovement;
    private Camera _camera;
    private User _user;

    private void Start()
    {
        _photonView = GetComponent<PhotonView>();
        _userMovement = GetComponent<UserMovement>();
        _controlable = new KeyboardController(_userMovement);
        _camera = Camera.main;

        _nickNameText.SetText(_photonView.Owner.NickName);
        _user = GetComponent<User>();

        if (!_photonView.IsMine)
        {
            _nickNameText.color = Color.green;
        }

        EventManager.OnAddUsersInList(_user);
        EventManager.OnSpawnInformationUserPanel(_user);


        InformationUserPanel.GetComponent<UserNicknameInInformationUserPanel>().SetUserNickname(_nickNameText.text);
        InformationUserPanel.GetComponent<SetID>().SetIDText(_photonView.Owner.ActorNumber.ToString());
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

    private void OnDestroy()
    {
        Debug.Log("Destroy");
        EventManager.OnRemoveUsersInList(_user);

        Destroy(InformationUserPanel);
    }
}

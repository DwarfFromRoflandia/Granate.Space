using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class EntryPointCallScene : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;

    [SerializeField] private User _user;
    [SerializeField] private PhotonView _view;
    private IControlable controlable;
    private void Start()
    {
        _gameManager.Initialize();

        controlable = new KeyboardController();
        _user.Initialize(controlable, _view);
    }
}

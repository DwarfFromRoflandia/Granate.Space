using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class EntryPointCallScene : MonoBehaviour
{
    [SerializeField] private GameObject _informationPanelPrefab;
    [SerializeField] private GameObject _contentScrollView;

    [SerializeField] private GameManager _gameManager;
    [SerializeField] private CameraShake _cameraShake;
    [SerializeField] private PostProcessingScreenEdges _postProcessingScreenEdges;

    [SerializeField] private SpawnInformationUserPanel _spawnInformationUserPanel;
    [SerializeField] private UsersList _userList;

    private void Start()
    {
        _cameraShake.Initialize();
        _gameManager.Initialize();
        _postProcessingScreenEdges.Initialize();

        _spawnInformationUserPanel.Initialize();

        UsersList _usersList = new UsersList();
    }
}

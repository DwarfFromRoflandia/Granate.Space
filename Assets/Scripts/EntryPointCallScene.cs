using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class EntryPointCallScene : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private CameraShake _cameraShake;

    private void Start()
    {
        _cameraShake.Initialize();
        _gameManager.Initialize();
    }
}

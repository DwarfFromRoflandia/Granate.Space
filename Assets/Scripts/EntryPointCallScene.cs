using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class EntryPointCallScene : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;
    private void Start()
    {
        _gameManager.Initialize();
    }
}

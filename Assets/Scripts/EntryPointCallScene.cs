using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointCallScene : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;
    private void Start()
    {
        _gameManager.Intialize();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class SpawnKickButton : MonoBehaviour
{
    [SerializeField] private Button prefabKickButton;
    private GameObject _context;

    private void Start()
    {
        _context = gameObject;
    }
    public void Spawn(Dictionary<int, User> UserDictionary)
    {
       
    }


}

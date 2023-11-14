using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private Transport _transport;
    [SerializeField] private Player _player;
    [SerializeField] private GameObject clonePrefabTransport;
    private void Start()
    {
        clonePrefabTransport = Instantiate(SpawnTransport.Spawn?.Invoke(), new Vector3(3,1,3), Quaternion.identity);

        //_player.Initialize(new KeyboardController());
        //_transport.Initialize(_player.Controllable, _player);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnTransport : MonoBehaviour
{
    private GameObject _transport;
    public delegate GameObject SpawnDelegate();
    public static SpawnDelegate Spawn;

    public void Spawnner(GameObject transport)
    {
        _transport = transport;
        Spawn += SetTransport;
        SceneManager.LoadScene("SampleScene");
    }

    private GameObject SetTransport() => _transport;
}

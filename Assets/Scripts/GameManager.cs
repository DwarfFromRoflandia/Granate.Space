using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class GameManager : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject _userPrefab;
    [SerializeField] private GameObject _userPrefabClone;

 
    public void Initialize()
    {
        StartCoroutine(SpawnSphereCoroutine());
    }

    public void LeaveButton() //the current player leaves the room
    {
        PhotonNetwork.LeaveRoom();
    }

    public override void OnLeftRoom()
    {
        PhotonNetwork.LoadLevel("SampleScene");
    }

    public override void OnPlayerEnteredRoom(Player newPlayer) //notification of the nickname of the player who entered the room
    {
        Debug.LogFormat("Player {0} entered the room", newPlayer.NickName);

        EventManager.OnCameraShake();
        EventManager.OnGlowEdgesScreen();  
    }

    public override void OnPlayerLeftRoom(Player otherPlayer) //notification of the nickname of the player who left the room
    {
        Debug.LogFormat("Player {0} left the room", otherPlayer.NickName);

        EventManager.OnCameraShake();
        EventManager.OnGlowEdgesScreen();
    }

    private IEnumerator SpawnSphereCoroutine()
    {
        yield return new WaitForSeconds(1f);
        Vector3 position = new Vector3(Random.Range(1, 6f), Random.Range(0.5f, 1f), Random.Range(1f, 6f));
        _userPrefabClone = PhotonNetwork.Instantiate(_userPrefab.name, position, Quaternion.identity);
    }
}

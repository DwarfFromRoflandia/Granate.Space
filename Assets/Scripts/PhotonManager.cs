using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class PhotonManager : MonoBehaviourPunCallbacks
{
    [SerializeField] private string _region;
    [SerializeField] private InputField _roomName;
    public void Intialize()
    {
        ConnectingToServer();
    }

    private void ConnectingToServer()
    {
        PhotonNetwork.ConnectUsingSettings(); //connecting to the server using file settings
        PhotonNetwork.ConnectToRegion(_region); //connecting to the required region
    }

    public override void OnConnectedToMaster() //called when the client is connected to the Master Server and ready for matchmaking and other tasks.

    {
        Debug.Log($"connected to the region: {PhotonNetwork.CloudRegion}");
    }

    public override void OnDisconnected(DisconnectCause cause) //Called after disconnecting from the Photon server. The reason for this disconnect is provided as DisconnectCause.
    {
        Debug.Log("the connection from the server is disconnected");
    }

    public void CreateRoomButton()
    {
        RoomOptions roomOptions = new RoomOptions(); //RoomOptions wraps up common room properties needed when you create rooms.
        roomOptions.MaxPlayers = 20;
        PhotonNetwork.CreateRoom(_roomName.text, roomOptions, TypedLobby.Default); //Creates a new room.When successful, this calls the callbacks OnCreatedRoom and OnJoinedRoom (the latter, cause you join as first player). Creating a room will fail if the room name is already in use. 
    }

    public override void OnCreatedRoom()
    {
        Debug.Log($"room {PhotonNetwork.CurrentRoom.Name} has been created");
    }
}

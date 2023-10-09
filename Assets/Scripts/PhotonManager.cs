using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PhotonManager : MonoBehaviour
{
    public void Intialize()
    {
        ConnectingToServer();
    }

    private void ConnectingToServer()
    {
        PhotonNetwork.ConnectUsingSettings(); //connecting to the server using file settings
    }
}

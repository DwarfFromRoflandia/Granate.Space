using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class ButtonServiceOnPanelMoreActions : MonoBehaviour
{
    private SetIdService _setIdService;

    public void Initialize()
    {
        _setIdService = new SetIdService();
    }


    private void SetNumberButtons(User user)
    {
        // instead of true, I mean tracking my own panel. it will be implemented later
        if (true && user.PhotonView.Owner.NickName == PhotonNetwork.MasterClient.NickName || user.PhotonView.Owner.NickName != PhotonNetwork.MasterClient.NickName)
        {
            // spawn 4 buttons
        }
        else if(user.PhotonView.Owner.NickName == PhotonNetwork.MasterClient.NickName)
        {
            // spawn 6 buttons
        }
        else
        {
            // spawn 5 buttons
        }
    }
}

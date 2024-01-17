using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SetIdService
{
    public Dictionary<int, User> UserDictionary = new Dictionary<int, User>();
    public Dictionary<int, GameObject> InformationalPanelDictionary = new Dictionary<int, GameObject>();

    public SetIdService()
    {
        EventManager.SetIDInDictionaryEvent.AddListener(SetID);
        EventManager.DisableIDInDictionaryEvent.AddListener(DisableID);
    }

    private void SetID(User user, GameObject InformationalPanel)
    {
        UserDictionary.Add(user.PhotonView.Owner.ActorNumber, user);
        InformationalPanelDictionary.Add(user.PhotonView.Owner.ActorNumber, user.InformationUserPanel);
    }

    private void DisableID(User user)
    {
        UserDictionary.Remove(user.PhotonView.Owner.ActorNumber);
        InformationalPanelDictionary.Remove(user.PhotonView.Owner.ActorNumber);
    }
}

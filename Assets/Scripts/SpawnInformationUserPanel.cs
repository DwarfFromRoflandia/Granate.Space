using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Photon.Pun;

public class SpawnInformationUserPanel : MonoBehaviour
{
    [SerializeField] private GameObject _informationPanelPrefab;
    [SerializeField] private GameObject contentScrollView;
    private int _userKey = 0;
   
    Dictionary<int, User> UserDictionary = new Dictionary<int, User>()
    {

    };    
    
    public void Initialize()
    {
        EventManager.AddUsersInDictionaryEvent.AddListener(AddUsers);
        EventManager.RemoveUsersInDictionaryEvent.AddListener(RemoveUsers);
    }

    private void Update()
    {

    }

    private void AddUsers(User user)
    {
        SpawnPanel(user);
        AddUserInDictionary(user);
    }

    private void RemoveUsers(int key)
    {
        UserDictionary.Remove(key);
    }

   
    private void SpawnPanel(User user) => user.InformationUserPanel = Instantiate(_informationPanelPrefab, contentScrollView.transform);

    private void AddUserInDictionary(User user)
    {
        _userKey++;
        user.SetID = _userKey;
        UserDictionary.Add(_userKey, user);
    }


    private void FindHostLobby()
    {
        //for (int i = 1; i <= UserDictionary.Count; i++)
        //{
        //    if (UserDictionary[i].PhotonView.Owner.NickName == PhotonNetwork.MasterClient.NickName)
        //    {
        //        Debug.Log($"Хост лобби находится под никнеймом {UserDictionary[i].PhotonView.Owner.NickName}");
        //    }
        //}
    }
}

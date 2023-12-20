using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
using Photon.Realtime;


public class WindowUsers : MonoBehaviour
{
    [SerializeField] private GameObject _userPanelPrefab;
    [SerializeField] private GameObject contentScrollView;
    private int _userKey = 0;
   
    Dictionary<int, User> UserDictionary = new Dictionary<int, User>()
    {

    };    
    
    public void Initialize()
    {
        EventManager.WindowUsersEvent.AddListener(AddUsers);
    }

    private void AddUsers(User user)
    {
        SpawnInformationUserPanel(user);
        AddUserInDictionary(user);
    }

   
    private void SpawnInformationUserPanel(User user) => user.InformationUserPanel = Instantiate(_userPanelPrefab, contentScrollView.transform);

    private void AddUserInDictionary(User user)
    {
        _userKey++;
        user.SetID(_userKey);
        UserDictionary.Add(_userKey, user);
    }
}

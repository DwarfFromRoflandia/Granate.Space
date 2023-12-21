using System.Collections;
using System.Collections.Generic;
using UnityEngine;



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
        EventManager.WindowUsersEvent.AddListener(AddUsers);
    }

    private void AddUsers(User user)
    {
        SpawnPanel(user);
        AddUserInDictionary(user);
    }

   
    private void SpawnPanel(User user) => user.InformationUserPanel = Instantiate(_informationPanelPrefab, contentScrollView.transform);

    private void AddUserInDictionary(User user)
    {
        _userKey++;
        user.SetID(_userKey);
        UserDictionary.Add(_userKey, user);
    }
}

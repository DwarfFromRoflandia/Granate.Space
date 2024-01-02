using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;



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
        //FindHostLobby();
    }

    private void AddUsers(User user)
    {
        SpawnPanel(user);
        AddUserInDictionary(user);
    }

    private void RemoveUsers(int key)
    {
        UserDictionary.Remove(key);

        Debug.Log($"Удалён пользователь с ключём: {key}");

        foreach (var item in UserDictionary)
        {
            Debug.Log($"Отсался пользователь с ключём {item.Key}");
        }
    }

   
    private void SpawnPanel(User user) => user.InformationUserPanel = Instantiate(_informationPanelPrefab, contentScrollView.transform);

    private void AddUserInDictionary(User user)
    {
        _userKey++;
        user.SetID(_userKey);
        UserDictionary.Add(_userKey, user);

        Debug.Log($"Был добавлен пользователь с ключём {_userKey}");

        foreach (var item in UserDictionary)
        {
            Debug.Log($"Другой пользователь в комнате под ключём: {item.Key}");
        }
    }

    private int Test()
    {
        //return UserDictionary.Keys.Min();
        //return UserDictionary.Keys.FirstOrDefault();
        //return UserDictionary.Keys.First();

        var first = UserDictionary.First();
        return first.Key;
    }

    private void FindHostLobby()
    {
        Debug.Log($"Хост лобби находится под ключём: {Test()}");

        //for (int i = 1; i <= UserDictionary.Count; i++)
        //{
        //    if (i == Test())
        //    {
        //        Debug.Log($"Хост лобби находится под ключём {Test()} и имеет ник {UserDictionary[i].PhotonView.Owner.NickName}");
        //    }
        //}

        foreach (var item in UserDictionary)
        {
            if (item.Key == Test())
            {
                Debug.Log($"Хост лобби находится под ключём: {Test()}");
            }
        }
    }
}

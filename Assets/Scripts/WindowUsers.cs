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
    public List<User> _usersArray = new List<User>();
    public List<GameObject> _usersPanelArray = new List<GameObject>();
    private int idUser = 0;
    public void Initialize()
    {
        EventManager.WindowUsersEvent.AddListener(AddUsers);
        EventManager.RemoveUserFromWindowUsersEvent.AddListener(RemoveUser);
        EventManager.SetUserNicknameEvent.AddListener(SetUserName);
    }

    private void AddUsers(User user)
    {
        UserDictionary.Add(idUser, user);
        Instantiate(_userPanelPrefab,contentScrollView.transform);
        idUser++;
    }

    Dictionary<int, User> UserDictionary = new Dictionary<int, User>()
    {

    };

    private void SetUserName(TextMeshProUGUI nicknameText)
    {
        for (int i = 0; i < UserDictionary.Count; i++)
        {
            nicknameText.text = $"{UserDictionary[i].PhotonView.Owner.NickName}";
        }
    }

    private void RemoveUser(User user)
    {
        _usersArray.Remove(user);
        SetTexts();
    }

    private void SetTexts()
    {
        for (int i = 0; i < UserDictionary.Count; i++)
        {
            transform.GetChild(i).GetComponent<Text>().text = $"{i} {UserDictionary[i].PhotonView.Owner.NickName}";
            Debug.Log("SetText");
        }
    }
}

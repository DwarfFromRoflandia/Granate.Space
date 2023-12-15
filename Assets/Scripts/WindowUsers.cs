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

    public void Initialize()
    {
        foreach (var niknameText in GetComponentsInChildren<Text>())
        {
            niknameText.text = "";
        }

        EventManager.WindowUsersEvent.AddListener(AddUsers);
        EventManager.RemoveUserFromWindowUsersEvent.AddListener(RemoveUser);
    }

    private void AddUsers(User user)
    {
        _usersArray.Add(user);
        SetTexts();
    }

    private void RemoveUser(User user)
    {
        _usersArray.Remove(user);
        SetTexts();
    }

    private void SetTexts()
    {
        for (int i = 0; i < _usersArray.Count; i++)
        {
            transform.GetChild(i).GetComponent<Text>(). text = $"{i} {_usersArray[i].PhotonView.Owner.NickName}";
            Debug.Log("SetText");
        }
    }
}

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
    }

    //public void TestButton()
    //{

    //    Test.Add(idUser, "Element");
    //    Debug.Log($"Count: {Test.Count}");
    //    Debug.Log(Test[idUser]);

    //    idUser++;
    //}

    private void AddUsers(User user)
    {
        Test.Add(idUser, user);
        Instantiate(_userPanelPrefab,contentScrollView.transform);
        idUser++;
        EventManager.OnSetUserNickname(Test, idUser);

        Debug.Log(user.gameObject);
        Debug.Log(Test.Count);
    }

    Dictionary<int, User> Test = new Dictionary<int, User>()
    {

    };

    //private void AddUsers(User user)
    //{
    //    _usersArray.Add(user);
    //    SetTexts();
    //}

    private void RemoveUser(User user)
    {
        _usersArray.Remove(user);
        SetTexts();
    }

    private void SetTexts()
    {
        for (int i = 0; i < Test.Count; i++)
        {
            transform.GetChild(i).GetComponent<Text>().text = $"{i} {Test[i].PhotonView.Owner.NickName}";
            Debug.Log("SetText");
        }
    }
}

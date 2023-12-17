using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UserNicknameInInformationUserPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI userNickname;
    private string _nickname;

    private void Start()
    {
        userNickname = GetComponent<TextMeshProUGUI>();
        EventManager.SetUserNicknameEvent.AddListener(SetUserName);

    }

    private void SetUserName(Dictionary<int, User> dictionaryUsers, int key)
    {
        for (int i = 0; i < key; i++)
        {
            
        }
        userNickname.text = $"{dictionaryUsers[key].PhotonView.Owner.NickName}";
        _nickname = $"{dictionaryUsers[key].PhotonView.Owner.NickName}";
        Debug.Log("Test");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UserNicknameInInformationUserPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI userNickname;

    public void SetUserNickname(string nickname)
    {
        userNickname.text = nickname;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UserNicknameInInformationUserPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI userNickname;

    private void Start()
    {
        userNickname = GetComponent<TextMeshProUGUI>();
        EventManager.OnSetUserNickname(userNickname);
    }
}

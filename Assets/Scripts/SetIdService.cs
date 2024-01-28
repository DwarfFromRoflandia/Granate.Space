using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetIDService : MonoBehaviour
{
    [SerializeField] private Transform _contentTransform;

    public List<GameObject> PanelList = new List<GameObject>();

    public List<GameObject> UserList = new List<GameObject>();

    public void Initialize()
    {
        EventManager.AddPanelInListEvent.AddListener(AddPanel);
        EventManager.AddUserInListEvent.AddListener(AddUser);

        EventManager.RemovePanelInListEvent.AddListener(RemovePanel);
        EventManager.RemoveUserInListEvent.AddListener(RemoveUser);
    }

    public void AddUser(GameObject user)
    {
        UserList.Add(user);

        Debug.Log("SpawnUser");
    }

    public void AddPanel(GameObject informationalPanel)
    {
        PanelList.Add(informationalPanel);
        informationalPanel.transform.SetParent(_contentTransform, false);

        Debug.Log("SpawnPanel");
        ConnectingNodeFromPanelToUser();
    }

    public void RemoveUser(GameObject user)
    {
        UserList.Remove(user);
    }

    public void RemovePanel(GameObject informationalPanel)
    {
        PanelList.Remove(informationalPanel);
    }

    public void ConnectingNodeFromPanelToUser()
    {
        for (int i = 0; i < PanelList.Count; i++)
        {
            PanelList[i].GetComponent<UserNicknameInInformationUserPanel>().SetUserNickname(UserList[i].GetComponent<User>().PhotonView.Owner.NickName);
            PanelList[i].GetComponent<SetID>().SetIDText(UserList[i].GetComponent<User>().PhotonView.Owner.ActorNumber.ToString());
        }
    }

    public void ConnectingNodeFromUserToPanel()
    {
        for (int i = 0; i < UserList.Count; i++)
        {
            
        }
    }
}

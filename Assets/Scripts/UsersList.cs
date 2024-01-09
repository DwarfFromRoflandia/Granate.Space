using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsersList
{
    public List<User> UserList = new List<User>();

    public UsersList()
    {
        EventManager.AddUsersInListEvent.AddListener(AddUsers);
        EventManager.RemoveUsersInListEvent.AddListener(RemoveUsers);
    }

    private void AddUsers(User user)
    {
        UserList.Add(user);
        Test();
    }

    private void RemoveUsers(User user)
    {
        UserList.Remove(user);
        Test();
    }

    private void Test()
    {
        for (int i = 0; i < UserList.Count; i++)
        {
            Debug.Log($"The nickname of the user in the list: {UserList[i].PhotonView.Owner.NickName} and the type of the object: {UserList[i].name}");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowsAniamtions : MonoBehaviour
{
    public void OpenWindow(GameObject window)
    {
        Animator animator;
        animator = window.GetComponent<Animator>();
        animator.SetTrigger("Open");
    }

    public void CloseWindow(GameObject window)
    {
        Animator animator;
        animator = window.GetComponent<Animator>();
        animator.SetTrigger("Close");
    }
}

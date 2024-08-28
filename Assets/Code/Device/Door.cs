#pragma warning disable 0649
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    bool _isOpen = false;
    bool _isLocked = false;
    [SerializeField]
    int _autoCloseTimer = 0;
    public void GotInteracted()
    {
        throw new System.NotImplementedException();
    }

    public void OpenManual(){

    }
    public void Open(){

    }
    public void Close(){

    }
}

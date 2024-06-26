#pragma warning disable 0649
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityEngine.Events;
using UnityEngine.Animations;

//Uses Contains from UnityExtension layer mask extension method

/// <summary>
/// Detects if a[ny] thing is in the trigger area
/// Remember, OnTrigger Events require IsTrigger to be checked as well as at least one rigidbody involved in the collision
/// </summary>

public class Detector : SerializedMonoBehaviour
{
    [SerializeField]
    LayerMask mask;
    [SerializeField]
    HashSet<GameObject> collidingWith = new HashSet<GameObject>();
    public bool IsBlocked => collidingWith.Count > 0;
    public event Action OnBlocked;
    public event Action OnUnblocked;
    [SerializeField]
    UnityEvent BlockedEvent;
    [SerializeField]
    UnityEvent UnblockedEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (mask.Contains(other.gameObject))
            collidingWith.Add(other.gameObject);
        if (collidingWith.Count == 1)
        {
            OnBlocked?.Invoke();
            BlockedEvent?.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (mask.Contains(other.gameObject))
            collidingWith.Remove(other.gameObject);
        if (collidingWith.Count == 0)
        {
            UnblockedEvent?.Invoke();
            OnUnblocked?.Invoke();
        }
    }
}

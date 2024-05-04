#pragma warning disable 0649
using System;
using System.Collections.Generic;
using UnityEngine;

public class EventStream: MonoBehaviour{
    static EventStream T;
    Dictionary<string, List<Action<float>>> _listeners = new();
    public static void AddListener(string eventName, Action<float> listener)
    {
        if (T._listeners.ContainsKey(eventName))
            T._listeners[eventName].Add(listener);
        else
            T._listeners[eventName] = new List<Action<float>> { listener };
    }
    public static void RemoveListener(string eventName, Action<float> listener)
    {
        if (T._listeners.ContainsKey(eventName))
            T._listeners[eventName].Remove(listener);
    }

    internal static void Emit(string key, float val)
    {
        if (T._listeners.ContainsKey(key))
            T._listeners[key].ForEach(listener => listener(val));
    }

    private void Awake()
    {
        if(T == null)
            T = this;
        else
            Destroy(gameObject);
    }
}
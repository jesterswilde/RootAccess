#pragma warning disable 0649
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.Utilities;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager T;
    [SerializeField, BoxGroup("Art")]
    Material _outlineMaterial;
    [SerializeField]
    PlayerSettings playerSettings;
    [SerializeField]
    Canvas canvas;
    public static Material OutlineMaterial => T._outlineMaterial;
    public static Canvas Canvas => T.canvas;
    public static PlayerSettings PlayerSettings => T.playerSettings;
    Dictionary<string, float> _flags = new Dictionary<string, float>();
    public static void SetFlag(string flag, float value)
    {
        T._flags[flag] = value;
    }
    public static float GetFlag(string flag)
    {
        if (T._flags.ContainsKey(flag))
            return T._flags[flag];
        return 0;
    }
    public static void IncrmentFlag(string flag, float value = 1)
    {
        if (T._flags.ContainsKey(flag))
            T._flags[flag] += value;
        else
            T._flags[flag] = value;
    }


    private void Start()
    {
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
    }
    private void Awake()
    {
        T = this;
    }
}

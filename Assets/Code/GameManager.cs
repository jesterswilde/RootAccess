using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager T;
    [SerializeField]
    PlayerSettings playerSettings;
    [SerializeField]
    Canvas canvas;
    public static Canvas Canvas => T.canvas;
    public static PlayerSettings PlayerSettings => T.playerSettings;


    private void Awake()
    {
        T = this;
    }
}
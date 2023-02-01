using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager T;
    [SerializeField]
    PlayerSettings playerSettings;
    public static PlayerSettings PlayerSettings => T.playerSettings;


    private void Awake()
    {
        T = this;
    }
}
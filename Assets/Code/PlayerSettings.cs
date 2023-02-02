using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSettings", menuName = "Root/PlayerSettings", order = 1)]
public class PlayerSettings : ScriptableObject
{
    public float CameraSensitivity = 10;
    public bool InvertCamera = false;
    public float MoveSpeed = 7;
    public float SprintSpeed = 12;
    public float JumpPower = 10; 
}

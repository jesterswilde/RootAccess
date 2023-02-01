using UnityEngine;

public class Player : MonoBehaviour
{
    static Player T;
    PlayerSettings settings => GameManager.PlayerSettings;
    public static Vector3 Position => T.transform.position;
    CharacterController ch; 

    void Move()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var z = Input.GetAxisRaw("Vertical");
        Debug.Log(z);
        var norm = new Vector3(x, 0, z).normalized;

        var right = CameraController.Right;
        right.y = 0;
        right.Normalize();

        var forward = CameraController.Forward;
        forward.y = 0;
        forward.Normalize();
        ch.Move((right * norm.x + forward * norm.z) * Time.deltaTime * settings.MoveSpeed);
    }
    private void Update()
    {
        Move();
    }

    private void Awake()
    {
        T = this;
        ch = GetComponentInChildren<CharacterController>();
    }
}

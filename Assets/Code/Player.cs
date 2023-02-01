using UnityEngine;

public class Player : MonoBehaviour
{
    static Player T;
    PlayerSettings settings => GameManager.PlayerSettings;
    public static Vector3 Position => T.transform.position;
    CharacterController ch;
    float yMotion = 0;
    [SerializeField]
    Detector groundDetector;
    bool isGrounded => groundDetector.IsBlocked;

    void Move()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var z = Input.GetAxisRaw("Vertical");
        var norm = new Vector3(x, 0, z).normalized;

        var right = CameraController.Right;
        right.y = 0;
        right.Normalize();

        var forward = CameraController.Forward;
        forward.y = 0;
        forward.Normalize();
        ch.Move((right * norm.x + forward * norm.z) * Time.deltaTime * settings.MoveSpeed + yMotion * Vector3.up * Time.deltaTime);
    }
    void Jump()
    {
        if (!isGrounded)
        {
            yMotion += Physics.gravity.y * Time.deltaTime;
            //Debug.Log("Not grounded");
        }
        else
        {
            //Debug.Log("grounded");
            if(yMotion < 0)
                yMotion = Physics.gravity.y * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
                yMotion += settings.JumpPower;
        }
    }
    private void Update()
    {
        Jump();
        Move();
    }

    private void Awake()
    {
        T = this;
        ch = GetComponentInChildren<CharacterController>();
    }
}

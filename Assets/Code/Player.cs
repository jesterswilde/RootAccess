#pragma warning disable 0649
using UnityEngine;
using Sirenix.Utilities;

public class Player : MonoBehaviour
{
    static Player T;
    PlayerSettings settings => GameManager.PlayerSettings;
    public static Vector3 Position => T.transform.position;
    CharacterController ch;
    float yMotion = 0;
    [SerializeField]
    Detector groundDetector;
    [SerializeField]
    Transform standingPos;
    [SerializeField]
    Transform crouchingPos;
    [SerializeField]
    Transform throwPos;
    [SerializeField]
    Transform camPos;
    public static Vector3 CamPos => T.camPos.position;
    [SerializeField]
    float throwForce = 10f;
    Cyberdeck deck;
    ControlPanel powerbrick;
    [SerializeField]
    LayerMask mask;
    bool isGrounded => groundDetector.IsBlocked;
    //THIS IS UGLY AS SHIT. THIS NEEDS TO BE HANDLED ELSEWHERE
    Rigidbody rigidBrick;
    float brickTimer = 0;
    float brickThreshold = 2f;
    bool isCrouching = false;
    float crouchLerp = 0;
    [SerializeField]
    float crouchLerpSpeed = 0.5f;

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
        float speed = Input.GetKey(KeyCode.LeftShift) ? settings.SprintSpeed : settings.MoveSpeed;
        ch.Move((right * norm.x + forward * norm.z) * Time.deltaTime * speed + yMotion * Vector3.up * Time.deltaTime);
    }
    void Jump()
    {
        if (!isGrounded)
        {
            yMotion += Physics.gravity.y * Time.deltaTime;
        }
        else
        {
            if(yMotion < 0)
                yMotion = Physics.gravity.y * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
                yMotion += settings.JumpPower;
        }
    }
    void TryPickup()
    {
        Vector3 origin = CameraController.Cam.transform.position;
        Vector3 dir = CameraController.Cam.transform.forward;

        Ray ray = new Ray(origin, dir);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 5, mask))
        {
            var powerbrick = hit.collider.gameObject.GetComponentInParent<ControlPanel>();
            if(powerbrick != null)
            {
                PickupPowerbrick(powerbrick);
                return;
            }
            var deck = hit.collider.gameObject.GetComponentInParent<Cyberdeck>();
            if (deck != null)
            {
                PickupDeck(deck);
                return;
            }
        }
    }
    void PickupPowerbrick(ControlPanel _powerbrick)
    {
        powerbrick = _powerbrick;
        var rigid = powerbrick.GetComponentInChildren<Rigidbody>();
        Destroy(rigid);
        powerbrick.GetComponentsInChildren<Renderer>().ForEach(r => r.enabled = false);
        powerbrick.GetComponentsInChildren<Collider>().ForEach(c => c.enabled = false);
        powerbrick.transform.position = throwPos.position;
        powerbrick.transform.SetParent(throwPos);
    }
    void BrickPhysTimer()
    {
        if (rigidBrick == null)
            return;
        brickTimer += Time.deltaTime;
        if(brickTimer > brickThreshold)
        {
            Destroy(rigidBrick);
            rigidBrick = null;
            brickTimer = 0;
        }
    }
    void ThrowBrick()
    {
        if (powerbrick == null)
            return;
        rigidBrick = powerbrick.gameObject.AddComponent<Rigidbody>();
        rigidBrick.mass = 20;
        rigidBrick.isKinematic = false;
        rigidBrick.useGravity = true;
        rigidBrick.AddForce(throwPos.transform.forward * throwForce, ForceMode.Impulse);
        powerbrick.transform.SetParent(null);
        powerbrick.transform.forward = throwPos.transform.forward * -1;
        powerbrick.GetComponentsInChildren<Renderer>().ForEach(r => r.enabled = true);
        powerbrick.GetComponentsInChildren<Collider>().ForEach(c => c.enabled = true);
        powerbrick = null;
    }
    void PickupDeck(Cyberdeck _cyberdeck)
    {
        deck = _cyberdeck;
        deck.GetComponentInChildren<Rigidbody>().isKinematic = true;
        deck.GetComponentsInChildren<Renderer>().ForEach(r => r.enabled = false);
        deck.GetComponentsInChildren<Collider>().ForEach(c => c.enabled = false);
        deck.transform.position = throwPos.position;
        deck.transform.SetParent(throwPos);
    }
    void ThrowDeck()
    {
        if (deck == null)
            return;
        var rigid = deck.GetComponentInChildren<Rigidbody>();
        rigid.isKinematic = false;
        rigid.useGravity = true;
        rigid.AddForce(throwPos.transform.forward * throwForce, ForceMode.Impulse);
        deck.transform.SetParent(null);
        deck.transform.forward = throwPos.transform.forward * -1;
        deck.GetComponentsInChildren<Renderer>().ForEach(r => r.enabled = true);
        deck.GetComponentsInChildren<Collider>().ForEach(c => c.enabled = true);
        deck = null;
    }
    void Crouching()
    {
        if (isCrouching && crouchLerp < 1)
        {
            crouchLerp += Time.deltaTime * (1 / crouchLerpSpeed);
            crouchLerp = Mathf.Min(1, crouchLerp);
            camPos.position = Vector3.Lerp(standingPos.position, crouchingPos.position, crouchLerp);
        }else if(!isCrouching && crouchLerp > 0)
        {
            crouchLerp -= Time.deltaTime * (1 / crouchLerpSpeed);
            crouchLerp = Mathf.Max(0, crouchLerp);
            camPos.position = Vector3.Lerp(standingPos.position, crouchingPos.position, crouchLerp);
        }
    }

    private void Update()
    {
        if (ControlManager.Mode != ControlMode.World)
            return;
        if (Input.GetKeyDown(KeyCode.F))
            TryPickup();
        if (Input.GetKeyDown(KeyCode.Alpha1))
            ThrowBrick();
        if (Input.GetKeyDown(KeyCode.Alpha2))
            ThrowDeck();
        if (Input.GetKeyDown(KeyCode.LeftControl))
            isCrouching = !isCrouching;
        Jump();
        Move();
        Crouching();
        //Ugly as sin. Also where the powerbrick in the air bug lives. 
        BrickPhysTimer();
    }

    private void Awake()
    {
        T = this;
        ch = GetComponentInChildren<CharacterController>();
    }
}

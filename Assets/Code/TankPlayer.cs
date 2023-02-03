using UnityEngine;

public class TankPlayer : MonoBehaviour
{
    [SerializeField]
    Transform shellPrefab;
    [SerializeField]
    Transform explosionPrefab;
    [SerializeField]
    Transform explosionSpot;
    [SerializeField]
    Transform shellSpot;
    [SerializeField]
    float maxSpeed;
    [SerializeField]
    float maxTurn;
    [SerializeField]
    ControlPanel conPan;
    float curSpeed;
    float curTurn;
    bool isOn;

    void Fire()
    {
        var explosion = Instantiate(explosionPrefab);
        explosion.transform.forward = explosionSpot.forward;
        explosion.transform.position = explosionSpot.position;
        var shell = Instantiate(shellPrefab);
        shell.transform.forward = shellSpot.forward;
        shell.transform.position = shellSpot.position;
    }
    void TurnOn(bool _isOn)=>
        isOn = _isOn;
    void SetSpeed(float speed) {
        curSpeed = speed * -1 * maxSpeed;
    }
    void SetTurn(float turn)
    {
        curTurn = turn * maxTurn;
    }
    public void AttachToControlPanel(ControlPanel powerbrick)
    {
        powerbrick.LinkToToggle(0, "ON", TurnOn);
        powerbrick.LinkToLever(0, "SPD", SetSpeed);
        powerbrick.LinkToLever(1, "TURN", SetTurn);
        powerbrick.LinkToButton(0, "CANN", Fire);
    }

    private void Move()
    {
        transform.Rotate(Vector3.up, curTurn * Time.deltaTime);
        transform.position += transform.forward * curSpeed * Time.deltaTime;
    }
    private void Start()
    {
        AttachToControlPanel(conPan);
    }
    private void Update()
    {
        if (!isOn)
            return;
        Move();
    }
}

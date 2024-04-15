#pragma warning disable 0649
using UnityEngine;

public class Tank : MonoBehaviour
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
    float curSpeed;
    float curTurn;
    bool _isOn;
    bool isPlayerControlled = false;
    public void Fire(float _)
    {
        var explosion = Instantiate(explosionPrefab);
        explosion.transform.forward = explosionSpot.forward;
        explosion.transform.position = explosionSpot.position;
        var shell = Instantiate(shellPrefab);
        shell.transform.forward = shellSpot.forward;
        shell.transform.position = shellSpot.position;
    }
    public void TurnOn(float val)=>
        _isOn = val > 0.5f;
    public void SetSpeed(float speed) {
        curSpeed = speed * -1 * maxSpeed;
    }
    public void SetTurn(float turn)
    {
        curTurn = turn * maxTurn;
    }
    private void Move()
    {
        transform.Rotate(Vector3.up, curTurn * Time.deltaTime);
        transform.position += transform.forward * curSpeed * Time.deltaTime;
    }
    public void SetPlayerControlled(bool _playerControlled)
    {
        isPlayerControlled = _playerControlled;
    }
    private void Update()
    {
        if (!_isOn)
            return;
        Move();
    }
}

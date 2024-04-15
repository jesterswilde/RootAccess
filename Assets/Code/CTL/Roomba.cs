#pragma warning disable 0649
using UnityEngine;

public class Roomba : MonoBehaviour
{
    Rigidbody rigid;
    [SerializeField]
    Renderer onLight;
    [SerializeField]
    Renderer vcmLight;
    [SerializeField]
    float maxSpeed;
    [SerializeField]
    float turnSpeed;
    float curSpeed;
    float curTurn;
    bool _isOn;
    Color offColor;
    [SerializeField]
    Color onColor;
    [SerializeField]
    Color vcmColor;
    bool _isVaccuming;
    [SerializeField]
    Detector detector;
    [SerializeField]
    AudioSource audioSource;

    public void SetSpeed(float speed)
    {
        curSpeed = maxSpeed * speed;
    }
    public void SetTurn(float turn)
    {
        curTurn = turnSpeed * turn;
    }
    public void SetOn(float val)
    {
        _isOn = val.ToBool();
        onLight.material.color = _isOn ? onColor : offColor;
        if (_isOn && _isVaccuming)
            audioSource.Play();
        else
            audioSource.Stop();
    }
    public void SetVaccum(float val)
    {
        _isVaccuming = val.ToBool();

        if (_isOn && _isVaccuming)
            audioSource.Play();
        else
            audioSource.Stop();
        vcmLight.material.color = _isOn ? vcmColor : offColor;
    }

    private void Update()
    {
        if (!_isOn || !detector.IsBlocked)
            return;
        transform.Rotate(Vector3.up, curTurn * Time.deltaTime);
        rigid.velocity = transform.forward * curSpeed;
    }
    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }
}

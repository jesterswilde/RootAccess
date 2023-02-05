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
    bool isOn;
    Color offColor;
    [SerializeField]
    Color onColor;
    [SerializeField]
    Color vcmColor;
    bool isVaccuming;
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
    public void SetOn(bool _isOn)
    {
        isOn = _isOn;
        onLight.material.color = isOn ? onColor : offColor;
        if (isOn && isVaccuming)
            audioSource.Play();
        else
            audioSource.Stop();
    }
    public void SetVaccum(bool isVcm)
    {
        isVaccuming = isVcm;

        if (isOn && isVaccuming)
            audioSource.Play();
        else
            audioSource.Stop();
        vcmLight.material.color = isOn ? vcmColor : offColor;
    }

    private void Update()
    {
        if (!isOn || !detector.IsBlocked)
            return;
        transform.Rotate(Vector3.up, curTurn * Time.deltaTime);
        rigid.velocity = transform.forward * curSpeed;
    }
    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }
}

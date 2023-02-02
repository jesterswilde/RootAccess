using UnityEngine;

public class NetworkViewer : MonoBehaviour
{
    static NetworkViewer T;

    private void Awake()
    {
        T = this;
    }
}

using UnityEngine;

public class GraphManager : MonoBehaviour
{
    static GraphManager T;
    Node currentNode;
    [SerializeField]
    Node startingNode;

    private void Awake()
    {
        T = this;
    }
}

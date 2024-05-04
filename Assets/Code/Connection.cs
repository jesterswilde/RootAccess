#pragma warning disable 0649
using UnityEngine;

public class Connection : MonoBehaviour
{
    [SerializeField]
    Node node1;
    public Node Node1 => node1;
    [SerializeField]
    Node node2;
    [SerializeField]
    int workToFind;
    public int WorkToFind => workToFind;
    [SerializeField]
    Permission perm = Permission.Guest;
    public Permission RequiredPerm => perm;
    public Node Node2 => node2;
    public Node GetOther(Node node)=>
        node == Node1 ? Node2 : Node1;
    bool isFound = false;
    public bool IsFound => isFound;
    public Permission HighestPermission => node2.Role.Greatest(node1.Role);

    public void DrawConnection()
    {
        Gradient grad;
        if (node1.Role.HasPermission(perm) || node2.Role.HasPermission(perm))
            grad = GraphManager.AccessColor;
        else
            grad = perm == Permission.Admin ? GraphManager.AdminColor : GraphManager.RootColor;
        var line = Instantiate(GraphManager.LinePrefab, transform);
        line.colorGradient = grad;
        line.material.color = grad.Evaluate(0);
        line.SetPositions(new Vector3[] { node1.transform.position, node2.transform.position });
    }
    public void FoundConnection()
    {
        if (isFound)
            return;
        isFound = true;
        DrawConnection();
    }

    private void OnDrawGizmos()
    {
        Color col = Color.green;
        if (perm == Permission.Admin)
            col = Color.yellow;
        if (perm == Permission.Admin)
            col = new Color(1, 0.75f, 0);
        if(node1 != null)
        {
            Gizmos.color = col;
            Gizmos.DrawLine(node1.transform.position, transform.position);
        }
        if(node2 != null)
        {
            Gizmos.color = col;
            Gizmos.DrawLine(node2.transform.position, transform.position);
        }
    }
    private void Start()
    {
        GraphManager.AddConnection(this);
    }
}

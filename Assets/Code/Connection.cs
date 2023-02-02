using System.Collections.Generic;
using System.Linq;
using UnityEditor;
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
    public Permission Perm => perm;
    public Node Node2 => node2;
    public Node GetOther(Node node)=>
        node == Node1 ? Node2 : Node1;
    bool isFound = false;
    public bool IsFound => isFound;

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
        List<GameObject> gos = new List<GameObject>();
        gos.Add(gameObject);
        if(node1 != null)
            gos.AddRange(node1.transform.GetLineage());
        if(node2 != null)
            gos.AddRange(node2.transform.GetLineage());

        bool shouldHighlight = gos.Any(go => Selection.Contains(go.GetInstanceID()));
        if (!shouldHighlight)
            return;
        if(node1 != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(node1.transform.position, transform.position);
        }
        if(node2 != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(node2.transform.position, transform.position);
        }
    }
    private void Start()
    {
        GraphManager.AddConnection(this);
    }
}

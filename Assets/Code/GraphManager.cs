#pragma warning disable 0649
using System.Collections.Generic;
using UnityEngine;

public class GraphManager : MonoBehaviour
{
    static GraphManager T;
    Dictionary<Node, List<Connection>> graph = new Dictionary<Node, List<Connection>>();

    [SerializeField]
    Node startingNode;
    [SerializeField]
    LineRenderer linePrefab;
    public static LineRenderer LinePrefab => T.linePrefab;
    [SerializeField]
    Gradient accessColor;
    public static Gradient AccessColor => T.accessColor;
    [SerializeField]
    Gradient adminColor;
    public static Gradient AdminColor => T.adminColor;
    [SerializeField]
    Gradient rootColor;
    public static Gradient RootColor => T.rootColor;

    public static void AddConnection(Connection con)
    {
        if (!T.graph.ContainsKey(con.Node1))
            T.graph[con.Node1] = new List<Connection>();
        T.graph[con.Node1].Add(con);
        if (!T.graph.ContainsKey(con.Node2))
            T.graph[con.Node2] = new List<Connection>();
        T.graph[con.Node2].Add(con);
    }
    public static List<Connection> GetConnections(Node node)
    {
        if (T.graph.ContainsKey(node))
            return T.graph[node];
        return new List<Connection>();
    }

    private void Awake()
    {
        T = this;
    }
}

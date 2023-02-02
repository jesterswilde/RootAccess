using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class Connection : MonoBehaviour
{
    [SerializeField]
    Node node1;
    [SerializeField]
    Node node2;

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
}

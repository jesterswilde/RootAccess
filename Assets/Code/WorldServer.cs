using UnityEngine;

[RequireComponent(typeof(Interactable))]
public class WorldServer : MonoBehaviour, IInteractable
{
    [SerializeField]
    int power;
    [SerializeField]
    Renderer dongleRend;
    public int Power => power;
    Interactable inter;

    public void GotInteracted()
    {
        Terminal.AddServer(this);
        if(dongleRend != null)
            dongleRend.enabled = false;
        inter.Deactivate();
    }
    private void Awake()
    {
        inter = GetComponent<Interactable>();
    }
}
public class WorldNodeEntry : MonoBehaviour, IInteractable
{
    [SerializeField]
    Node node;
    public void GotInteracted()
    {
        Terminal.T.SetNode(node);
    }
}


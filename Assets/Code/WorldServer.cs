#pragma warning disable 0649
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
    bool hasBeenUsed = false;

    public void GotInteracted()
    {
        if (hasBeenUsed)
            return;
        hasBeenUsed = true;
        Terminal.AddServer(this);
        if(dongleRend != null)
            dongleRend.enabled = true;
    }
    private void Awake()
    {
        if(dongleRend != null)
            dongleRend.enabled = false;
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


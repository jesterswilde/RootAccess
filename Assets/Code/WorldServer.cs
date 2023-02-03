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
            dongleRend.enabled = true;
        inter.Deactivate();
    }
    private void Awake()
    {
        inter = GetComponent<Interactable>();
    }
}


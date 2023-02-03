using UnityEngine;

[RequireComponent(typeof(Interactable))]
public class WorldProgram : MonoBehaviour, IInteractable
{
    [SerializeField]
    GameFile filePrefab;
    Interactable inter;
    public void GotInteracted()
    {
        if (Terminal.T != null)
            Terminal.T.AddFile(filePrefab);
        inter.Deactivate();
        Destroy(gameObject);
    }
    private void Awake()
    {
        inter = GetComponent<Interactable>();
    }
}


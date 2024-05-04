#pragma warning disable 0649
using UnityEngine;

public class Outfit : MonoBehaviour { 
    [SerializeField]
    Badge _badge;
    public Badge Badge { get => _badge; }
    public void AddBadge(Badge badge){
        if(_badge != null)
            Destroy(_badge.gameObject);
        _badge = Instantiate(badge, transform);
    }

    void Awake(){
        _badge = GetComponentInChildren<Badge>();
    }
}

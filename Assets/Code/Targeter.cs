#pragma warning disable 0649
using UnityEngine;
using System.Linq;

public class Targeter { 
    Interactable _target;
    Transform _rayPos;
    LayerMask _mask;
    public Interactable Target {
        get => _target;
        private set {
            if(_target == value)
                return;
            _target?.Untarget();
            _target = value;
            _target?.Target();
    }}
    
    void CheckTarget(){
        if(Physics.Raycast(_rayPos.position, _rayPos.forward, out var hit, 100, _mask))
        {
            var inter = hit.collider.GetComponentInParent<Interactable>();
            if(inter != null && inter.PlayerIsNear)
                Target = inter;
            else
                Target = null;
        }
        else
            Target = null;
    }

    public void Update(){
        CheckTarget();
    }
    public Targeter(Transform rayPos, LayerMask mask){
        _rayPos = rayPos;
        _mask = mask;
    }
}
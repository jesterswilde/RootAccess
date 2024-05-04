#pragma warning disable 0649
using System.Collections.Generic;
using UnityEngine;
using Sirenix.Utilities;
using Sirenix.OdinInspector;

public class MoverVolume : SerializedMonoBehaviour{
    [SerializeField]
    LayerMask _mask;
    [SerializeField, ReadOnly]
    HashSet<IMovable> _movers = new HashSet<IMovable>();

    internal void Move(Vector3 vector3)
    {
        foreach(var mover in _movers){
            mover.Move(vector3);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_mask.Contains(other.gameObject)){
            other.GetComponentsInParent<IMovable>().FilterCast<IMovable>().ForEach(m => _movers.Add(m));
        }
    }
    void OnTriggerExit(Collider other){
        if (_mask.Contains(other.gameObject)){
            other.GetComponentsInParent<IMovable>().FilterCast<IMovable>().ForEach(m => _movers.Remove(m));
        }
    }
}
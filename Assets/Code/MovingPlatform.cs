#pragma warning disable 0649
using Sirenix.Serialization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class MovingPlatform : MonoBehaviour{
    [SerializeField]
    MoverVolume _moverVolume;
    Vector3 lastPosition;

    void Update(){
        if (transform.position != lastPosition){
            _moverVolume.Move(transform.position - lastPosition);
            lastPosition = transform.position;
        }
    }

    void Awake(){
        lastPosition = transform.position;
    }
}
using UnityEngine;

public class Guard : MonoBehaviour { 
    public Alertness AlertLevel {get; private set; }
    float _suspicion;
    public float Suspicion {
        get => _suspicion;
        set {
            _suspicion = value;
            AlertLevel = Suspicion switch {
                < 30 => Alertness.Normal,
                < 70 => Alertness.Suspicious,
                _ => Alertness.Alert
            };
        }
    }
    public void EnteredWatchArea(Player player){

    }
    public void EneteredRestrictedArea(Player player){

    }
    public enum Alertness { 
        Normal,
        Suspicious,
        Alert
    }
}

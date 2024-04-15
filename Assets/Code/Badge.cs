#pragma warning disable 0649
using UnityEngine;

public class Badge : MonoBehaviour { 
    [SerializeField]
    BadgeType _badgeType;
    public BadgeType BadgeType => _badgeType;
    [SerializeField]
    Corporation _corp;
    public Corporation Corp => _corp;
    [SerializeField]
    Sprite _sprite;
    public Sprite Sprite => _sprite;
    public bool IsValid(Corporation corp, BadgeType badgeType)=>
        corp == _corp && (_badgeType & badgeType) != 0;
}

[System.Flags]
public enum BadgeType{
    Guest = 0,
    Employee = 1 << 0,
    Security = 1 << 1,
    Executive = 1 << 2,
    Admin = 1 << 3
}
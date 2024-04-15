#pragma warning disable 0649
using UnityEngine;

public class Counter : MonoBehaviour { 
    [SerializeField]
    TMPro.TMP_Text _text;
    int count = 0; 
    public void Increment() {
        count++;
        _text.text = count.ToString();
    }
    public void Set(int amount){
        count = amount;
        _text.text = count.ToString();
    }
}
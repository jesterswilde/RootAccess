#pragma warning disable 0649
using UnityEngine.UIElements;

public interface IUIController{
    public void Initialize(UIDocument doc);
    public void Teardown();
}
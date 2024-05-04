#pragma warning disable 0649
using System;

public class RequireFlag : Requirement{
    public string Flag;
    public float Value;
    public Comparators Comparator;
    Action<float> _listener;

    public override bool Evaluate()=> Comparator.Evaluate(GameManager.GetFlag(Flag), Value);
    public override void CreateAndAttachListener(Action completionListener = null) {
        if(completionListener != null)
            OnRequirementMet += completionListener;
        _listener = (newVal)=>{
            if(Comparator.Evaluate(newVal, Value)){
                Complete();
                RemoveListener();
            }
        };
        EventStream.AddListener(Flag, _listener);
    }

    public override void RemoveListener() {
        EventStream.RemoveListener(Flag, _listener);
    }
}

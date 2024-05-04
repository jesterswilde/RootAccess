#pragma warning disable 0649
using System;

public class RepRequirement : Requirement{
    public string RepWith;
    public float Value;
    public Comparators Comparator;

    public override void CreateAndAttachListener(Action completionListener = null)
    {
        throw new NotImplementedException();
    }

    public override bool Evaluate()=> Comparator.Evaluate(GameManager.GetFlag(RepWith+"_rep"), Value);

    public override void RemoveListener()
    {
        throw new NotImplementedException();
    }
}

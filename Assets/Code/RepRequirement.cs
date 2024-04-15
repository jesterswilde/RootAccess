#pragma warning disable 0649
public class RepRequirement : Requirement{
    public string RepWith;
    public float Value;
    public Comparators Comparator;

    public override bool Evaluate()=> Comparator.Evaluate(GameManager.GetFlag(RepWith+"_rep"), Value);
}

#pragma warning disable 0649
public class RequireFlag : Requirement{
    public string Flag;
    public float Value;
    public Comparators Comparator;

    public override bool Evaluate()=> Comparator.Evaluate(GameManager.GetFlag(Flag), Value);
}

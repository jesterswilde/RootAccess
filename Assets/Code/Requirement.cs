#pragma warning disable 0649
using System;

[Serializable]
public abstract class Requirement {
    public abstract bool Evaluate();
}


public static class ReqHelpers{
    public static bool Evaluate(this Comparators comp, float a, float b){
        switch(comp){
            case Comparators.GreaterThan:
                return a > b;
            case Comparators.LessThan:
                return a < b;
            case Comparators.EqualTo:
                return a == b;
        }
        return false;
    }
}
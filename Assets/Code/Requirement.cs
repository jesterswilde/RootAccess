#pragma warning disable 0649
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

[Serializable]
public abstract class Requirement {
    public abstract bool Evaluate();
    public abstract void CreateAndAttachListener(Action completionListener = null);
    public abstract void RemoveListener();
    public event Action OnRequirementMet;
    protected void Complete(){
        OnRequirementMet?.Invoke();
        OnRequirementMet = null;
    }
}

public class RequirementConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)=>
        objectType == typeof(Requirement);

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        JObject jo = JObject.Load(reader);
        Requirement req = jo["condition"].Value<string>() switch {
            "Flag" => new RequireFlag(),
            "PriorPost" => throw new NotImplementedException(),
            "Date" => throw new NotImplementedException(),
            "Rep" => throw new NotImplementedException(),
            _ => throw new NotImplementedException(),
        };
        serializer.Populate(jo.CreateReader(), req);
        return req;
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }
}


public static class ReqHelpers{
    public static bool Evaluate(this Comparators comp, float a, float b)=>
        comp switch {
            Comparators.GreaterThan => a > b,
            Comparators.LessThan => a < b,
            Comparators.EqualTo => a == b,
            Comparators.NotEqualTo => a != b,
            Comparators.GreaterThanEqualTo => a >= b,
            Comparators.LessThanEqualTo => a <= b,
            _ => false,
        };
}
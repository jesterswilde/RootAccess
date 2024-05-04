#pragma warning disable 0649
using System.Collections.Generic;
using Newtonsoft.Json;

public class ExtractableText
{
    public string Text { get; set; }
    public string Author { get; set; }
    public string Filename { get; set; }
    public string ID { get; set; }
    public List<DossierInfo> DossierInfo { get; set; }
    public static ExtractableText FromJSON(string json)=>
        JsonConvert.DeserializeObject<ExtractableText>(json);
}

public class DossierInfo
{
    public string Key { get; set; }
    public double MinPercentage { get; set; }
    public double MaxPercentage { get; set; }
    public DossierType InfoType { get; set; }
}

public enum DossierType
{
    Personal,
    Schedule,
    Employment,
    Contact
}

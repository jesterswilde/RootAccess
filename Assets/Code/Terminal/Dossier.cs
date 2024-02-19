#pragma warning disable 0649
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Unity.VisualScripting;
using UnityEngine;

public class Dossier {
}
public class DossierManager: MonoBehaviour { 
    public static DossierManager T {get; private set;}
    Dictionary<string, Dossier> Dossiers = new();
    public static void ExtracctedData(string id, string key){
        Debug.LogWarning("Extracted data (Not yet implemented): " + id + " " + key);
    }

    void Awake(){
        if(T == null){
            T = this;
        } else {
            Destroy(gameObject);
        }
    }
}
public class PersonDossier : Dossier { 
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public CompanyDossier Employer { get; set; }
}
public class CompanyDossier : Dossier { 
    public List<PersonDossier> Employees = new List<PersonDossier>();
}
public class Note { 

}
public class InGameEvent { 
    public int Day { get; set; }
    public string Title { get; set; }
    public bool HasTime { get; set; }
    public float Time { get; set; }
    public float Duration { get; set; }
}
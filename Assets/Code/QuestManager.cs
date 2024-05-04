#pragma warning disable 0649
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Sirenix.OdinInspector;
using UnityEngine;

public class QuestManager : SerializedMonoBehaviour { 
    public static QuestManager T {get; private set;}
    [SerializeField, Sirenix.OdinInspector.FilePath]
    List<string> _individualQuests = new();
    [SerializeField]
    List<string> _questObjectFiles = new();
    [SerializeField]
    Dictionary<string, Quest> _quests = new();

    
    public Quest GetQuestByName(string name)=>
        _quests.GetOrDefault(name);

    void Awake(){
        if(T != null){
            Destroy(this);        
        }
        T = this;
        var settings = new JsonSerializerSettings {
            Converters = new List<JsonConverter> { new RequirementConverter() }
        };
        foreach(var questPath in _individualQuests){
            using StreamReader reader = new(questPath);
            string questJSON = reader.ReadToEnd();
            var quest = JsonConvert.DeserializeObject<Quest>(questJSON, settings);
            _quests.Add(quest.Name, quest);
        }
        foreach(var questPath in _questObjectFiles){
            using StreamReader reader = new(questPath);
            string qusetJSON = reader.ReadToEnd();
            var quest = JsonConvert.DeserializeObject<Dictionary<string, Quest>>(qusetJSON);
            foreach(var k in quest.Keys){
                _quests.Add(k, quest[k]);
            }
        }
    }
}
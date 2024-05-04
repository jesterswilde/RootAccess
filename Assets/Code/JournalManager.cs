#pragma warning disable 0649
using System;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

[System.Serializable]
public class JournalManager : MonoBehaviour {
    public static JournalManager T { get; private set; }
    [SerializeField]
    List<Quest> ActiveQuests = new();
    List<CompletedQuest> CompletedQuests = new();
    public bool HasaActiveQuests => ActiveQuests.Count > 0;
    public void AddQuest(Quest quest){
        quest.Initialize();
        ActiveQuests.Add(quest);
        Refresh();
    }

    internal void CompletedQuest(Quest quest)
    {
        ActiveQuests.Remove(quest);
        CompletedQuests.Add(new CompletedQuest{Name = quest.Name, Description = quest.GetDescription()});
        Refresh();
    }
    void Refresh(){
        UIManager.T.RedrawSidebar();
    }
    public List<string> GetQuestDescriptions()=>
        ActiveQuests.Count == 0 ?
            new List<string>{"No active quests"} :
            ActiveQuests.Select(q=>q.GetDescription()).ToList();
    void Start(){
        ActiveQuests.Add( QuestManager.T.GetQuestByName("Hax0r").Initialize());
    }
    void Awake(){
        if(T == null)
            T = this;
        else{
            Destroy(gameObject);
            return;
        }
    }
}
public class  CompletedQuest{
    public string Name;
    public string Description;
}
[System.Serializable]
public class Quest {
    public string Name;
    public List<string> TempVariables;
    public List<Objective> Objectives = new();
    public bool IsActive = false;
    public bool IsComplete = false;
    public string GetDescription(){
        var activeObjectives = Objectives.Where(o=>o.IsActive);
        if(activeObjectives.Count() == 0)
            return "";
        return activeObjectives.Select(o=>o.GameText).Aggregate((a,b)=>$"{a}\n{b}");
    }

    void ObjectiveBecameActive(Objective obj){
        obj.IsActive = true;
    }
    void ObjectiveCompleted(Objective obj){
        if(Objectives.TrueForAll(o=>o.IsComplete)){
            IsComplete = true;
            IsActive = false;
            JournalManager.T.CompletedQuest(this);
        }
    }
    public Quest Initialize(){
        foreach(var obj in Objectives){
            obj.Initialize();
            if(!obj.IsActive && !obj.IsComplete)
                obj.OnBecomeActive += ObjectiveBecameActive;
            else if(obj.IsActive)
                obj.OnComplete += ObjectiveCompleted;
        }
        return this;
    }
}
[System.Serializable]
public class Objective {
    public string Name;
    public string GameText;
    public CompletionType CompleteAction;
    public List<RequirementState> StartRequirements = new();
    public List<RequirementState> EndRequirements = new();
    public bool IsActive = false;
    public bool IsComplete = false;
    public Action<Objective> OnBecomeActive;
    public Action<Objective> OnComplete;
    void OnStartReqComplete(){
        IsActive = StartRequirements.TrueForAll(r=>r.IsComplete);
        if(IsActive){
            InitalizeReqs(EndRequirements, OnEndReqComplete);
            OnBecomeActive?.Invoke(this);
            IsComplete = EndRequirements.TrueForAll(r=>r.IsComplete);
            if(IsComplete)
                OnComplete?.Invoke(this);
        }
    }
    void OnEndReqComplete(){
        IsComplete = EndRequirements.TrueForAll(r=>r.IsComplete);
        if(IsComplete){
            IsActive = false;
            if(CompletionType.Emit == CompleteAction)
                EventStream.Emit($"{Name}_complete", 1);
            else if(CompletionType.Write == CompleteAction)
                GameManager.SetFlag($"{Name}_complete", 1);
            OnComplete?.Invoke(this);
        }
    }
    public void Initialize(){
        InitalizeReqs(StartRequirements, OnStartReqComplete);
        IsActive = StartRequirements.TrueForAll(r=>r.IsComplete);
        if(!IsActive)
            return;
        InitalizeReqs(EndRequirements, OnEndReqComplete);
        IsComplete = EndRequirements.TrueForAll(r=>r.IsComplete);
    }
    void InitalizeReqs(List<RequirementState> reqs, Action onComplete){
        foreach(var req in reqs)
            if(req.Requirement.Evaluate())
                req.IsComplete = true;
            else
                req.Requirement.CreateAndAttachListener(onComplete);
    }
    public enum CompletionType{
        None,
        Emit,
        Write,
    }
}
public class RequirementState{
    public bool IsComplete = false;
    public Requirement Requirement;
}

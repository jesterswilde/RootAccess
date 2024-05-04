#pragma warning disable 0649
using System.Collections.Generic;
using UnityEngine;

public class CalendarManager : MonoBehaviour { 
    static CalendarManager t;
    public static CalendarManager T => t;
    List<ICalendrical> calendricals = new List<ICalendrical>();
    [SerializeField]
    int _dayNumber;
    public int DayNumber => _dayNumber;
    public void Register(ICalendrical calendrical){
        calendricals.Add(calendrical);
    }
    public void Unregister(ICalendrical calendrical){
        calendricals.Remove(calendrical);
    }
    public void BeginNextDay(Day day){
        _dayNumber++;
        foreach (var c in calendricals)
            c.BeginNextDay(day);
    }


    void Awake()
    {
        if (t == null)
            t = this;
        else
            Destroy(gameObject);
    }
}
public class Day {
    public int Number;
}

public interface ICalendrical { 
    public void BeginNextDay(Day day);
}
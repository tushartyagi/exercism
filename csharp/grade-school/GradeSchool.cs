using System;
using System.Collections.Generic;

public class Roster 
{

    private class StringComparer : IComparer<string>
    {
        int IComparer<string>.Compare(string x, string y)
        {
            return x.CompareTo(y);
        }
    }

    public Dictionary<int, List<string>> _roster {get; private set;}

    public List<string> this[int index] 
    {
        get {
            if (!_roster.ContainsKey(index)) 
                return new List<string>();
            else {
                return _roster[index];
            } 
        }
    }

     

    public int Count { 
        get { return _roster.Count; }
    }

    public Roster()
    {
        _roster = new Dictionary<int, List<string>>();
    }

    public void Add(int grade, string name) 
    {
        if (!_roster.ContainsKey(grade))
            _roster.Add(grade, new List<string>());
        
        _roster[grade].Add(name);
    }
}

public class School 
{

    public Roster Roster {get; private set;}

    public School()
    {
        Roster = new Roster();
    }
    
    public void Add(string name, int grade) 
    {
        Roster.Add(grade, name);
    }

    public List<string> Grade(int grade) 
    {
        return Roster[grade];
    }
}
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private SortedDictionary<int, List<string>> _roster = new SortedDictionary<int, List<string>>();

    public void Add(string studentName, int grade)
    {
        if (_roster.ContainsKey(grade))
        {
            _roster[grade].Add(studentName);
            _roster[grade].Sort();
        }
        else
        {
            _roster[grade] = new List<string> { studentName };
        }
    }

    public string[] Grade(int grade)
    {
        return _roster.ContainsKey(grade) ? _roster[grade].ToArray() : new string[0];
    }

    public string[] Roster()
    {
        return _roster.SelectMany(e => e.Value).ToArray();
    }
}

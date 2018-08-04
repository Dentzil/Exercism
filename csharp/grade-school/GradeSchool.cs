namespace Exercism_grade_school
{
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private Dictionary<int, List<string>> _roster = new Dictionary<int, List<string>>();

        public Dictionary<int, List<string>> Roster => _roster.ToDictionary(k => k.Key, v => v.Value.ToList());

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

        public List<string> Grade(int grade)
        {
            return _roster.ContainsKey(grade) ? _roster[grade].ToList() : new List<string>();
        }
    }
}

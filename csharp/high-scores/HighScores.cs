using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> _scores;
    private int _lastAdded;
    private int _personalBest;
    private List<int> _personalTopThree;

    public HighScores(List<int> list)
    {
        if (list is null)
        {
            throw new ArgumentNullException(nameof(list));
        }

        _scores = list.ToList();
        _lastAdded = list.Last();

        var sortedScores = list.OrderByDescending(e => e).ToList();
        _personalBest = sortedScores.First();
        _personalTopThree = sortedScores.Take(3).ToList();
    }

    public List<int> Scores()
    {
        return _scores.ToList();
    }

    public int Latest()
    {
        return _lastAdded;
    }

    public int PersonalBest()
    {
        return _personalBest;
    }

    public List<int> PersonalTopThree()
    {
        return _personalTopThree.ToList();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> _scores;
    private int? _lastAdded;
    private int? _personalBest;
    private List<int> _personalTopThree;

    public HighScores(List<int> list)
    {
        if (list is null)
        {
            throw new ArgumentNullException(nameof(list));
        }

        _scores = list.ToList();
    }

    public List<int> Scores()
    {
        return _scores.ToList();
    }

    public int Latest()
    {
        if (_lastAdded.HasValue == false)
        {
            _lastAdded = _scores.Last();
        }

        return _lastAdded.Value;
    }

    public int PersonalBest()
    {
        if (_personalBest.HasValue == false)
        {
            _personalBest = _scores.Max();
        }

        return _personalBest.Value;
    }

    public List<int> PersonalTopThree()
    {
        if (_personalTopThree is null)
        {
            _personalTopThree = _scores.OrderByDescending(e => e).Take(3).ToList();
        }

        return _personalTopThree.ToList();
    }

    /*
    public void Add(int score)
    {
        ...

        Foo();
    }

    private void Foo()
    {
        _lastAdded = null;
        _personalBest = null;
        _personalTopThree = null;
    }
    */
}

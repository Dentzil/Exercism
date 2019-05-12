using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Robot
{
    private const int LettersLength = 2;
    private const int NumbersLength = 3;

    private static readonly Random _rand = new Random();
    private static readonly HashSet<string> _robotNames = new HashSet<string>();

    private string _name = null;

    public string Name
    { 
        get
        {
            if (_name == null)
            {
                GenerateName();
            }

            return _name;
        }

        private set
        {
            _name = value;
        }
    }

    public void Reset()
    {
        _robotNames.Remove(Name);
        _name = null;
    }

    private void GenerateName()
    {
        string generatedName;
        bool isValidName;

        do
        {
            generatedName = GenerateRandomLetters(LettersLength) + GenerateRandomNumbers(NumbersLength);
            isValidName = _robotNames.Add(generatedName);
        } while (!isValidName);

        _name = generatedName;
    }

    private string GenerateRandomLetters(int length)
    {
        string letters = string.Concat(Enumerable.Range(0, length).Select(e => (char)_rand.Next(65, 91)));

        return letters;
    }

    private string GenerateRandomNumbers(int length)
    {
        string numbers = string.Concat(Enumerable.Range(0, length).Select(e => _rand.Next(0, 10)));

        return numbers;
    }
}

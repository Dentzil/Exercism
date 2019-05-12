using System;
using System.Collections.Generic;
using System.Linq;

[Flags]
enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

class Allergies
{
    private readonly Allergen _allergiesValue = 0;
    private readonly List<Allergen> _allergiesList = new List<Allergen>();

    public Allergies(int allergies)
    {
        _allergiesValue = (Allergen)allergies;

        var allergens = Enum.GetValues(typeof(Allergen)).Cast<Allergen>().ToList();
        foreach (var allergen in allergens)
        {
            if ((_allergiesValue & allergen) == allergen)
            {
                _allergiesList.Add(allergen);
            }
        }
    }

    public bool IsAllergicTo(Allergen allergy)
    {
        bool isAllergic = (_allergiesValue & allergy) == allergy;
        
        return isAllergic;
    }

    public Allergen[] List()
    {
        return _allergiesList.ToArray();
    }
}

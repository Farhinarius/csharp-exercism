using System;
using System.Collections.Generic;

public enum Allergens
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}
public class AllergiesMy
{
    private int _allergyScore;

    private static readonly int ALLERGY_MAX_SCORE = 255;

    private static readonly int ALLERGY_RESET = 256;

    public AllergiesMy(int allergyScore)
    {
        _allergyScore = allergyScore;
    }
    
    public bool IsAllergicTo(Allergens allergen)
    {
        if (_allergyScore <= 0 || Math.Pow(2, (int)allergen) > _allergyScore)
        {
            return false;
        }
        while (_allergyScore > ALLERGY_MAX_SCORE)
        {
            _allergyScore -= ALLERGY_RESET;
        }
        string binaryAllergyScore = Convert.ToString(_allergyScore, 2);
        return binaryAllergyScore[^((int)allergen + 1)] == '1' ? true : false;
    }
    
    public Allergens[] List()
    {
        List<Allergens> allergens = new List<Allergens>();
        while (_allergyScore > ALLERGY_MAX_SCORE)
        {
            _allergyScore -= ALLERGY_RESET;
        }
        if (_allergyScore <= 0)
        {
            return allergens.ToArray();
        }
        string binaryAllergyScore = Convert.ToString(_allergyScore, 2);
        for (int i = binaryAllergyScore.Length - 1; i >= 0; i--)
        {
            if (binaryAllergyScore[i] == '1')
            {
                allergens.Add((Allergens)(binaryAllergyScore.Length - i - 1));
            }
        }
        return allergens.ToArray();
    }
}

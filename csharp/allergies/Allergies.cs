using System;
using System.Linq;

[Flags]
public enum Allergen
{
    Eggs = 1 << 0,
    Peanuts = 1 << 1,
    Shellfish = 1 << 2,
    Strawberries = 1 << 3,
    Tomatoes = 1 << 4,
    Chocolate = 1 << 5,
    Pollen = 1 << 6,
    Cats = 1 << 7,
}
public class Allergies
{
    private Allergen _mask;

    public Allergies(int mask)
    {
        _mask = (Allergen)mask;
    }

    public bool IsAllergicTo(Allergen allergen) => _mask.HasFlag(allergen);

    public Allergen[] List()
    {
        return Enum.GetValues(typeof(Allergen))
            .Cast<Allergen>()
            .Where(IsAllergicTo)
            .ToArray();
    }
}
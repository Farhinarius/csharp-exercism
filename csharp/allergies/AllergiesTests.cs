using Xunit;

public class AllergiesTests
{
    [Fact]
    public void Testing_for_eggs_allergy_not_allergic_to_anything()
    {
        var sut = new AllergiesMy(0);
        Assert.False(sut.IsAllergicTo(Allergens.Eggs));
    }

    [Fact]
    public void Testing_for_eggs_allergy_allergic_only_to_eggs()
    {
        var sut = new AllergiesMy(1);
        Assert.True(sut.IsAllergicTo(Allergens.Eggs));
    }

    [Fact]
    public void Testing_for_eggs_allergy_allergic_to_eggs_and_something_else()
    {
        var sut = new AllergiesMy(3);
        Assert.True(sut.IsAllergicTo(Allergens.Eggs));
    }

    [Fact]
    public void Testing_for_eggs_allergy_allergic_to_something_but_not_eggs()
    {
        var sut = new AllergiesMy(2);
        Assert.False(sut.IsAllergicTo(Allergens.Eggs));
    }

    [Fact]
    public void Testing_for_eggs_allergy_allergic_to_everything()
    {
        var sut = new AllergiesMy(255);
        Assert.True(sut.IsAllergicTo(Allergens.Eggs));
    }

    [Fact]
    public void Testing_for_peanuts_allergy_not_allergic_to_anything()
    {
        var sut = new AllergiesMy(0);
        Assert.False(sut.IsAllergicTo(Allergens.Peanuts));
    }

    [Fact]
    public void Testing_for_peanuts_allergy_allergic_only_to_peanuts()
    {
        var sut = new AllergiesMy(2);
        Assert.True(sut.IsAllergicTo(Allergens.Peanuts));
    }

    [Fact]
    public void Testing_for_peanuts_allergy_allergic_to_peanuts_and_something_else()
    {
        var sut = new AllergiesMy(7);
        Assert.True(sut.IsAllergicTo(Allergens.Peanuts));
    }

    [Fact]
    public void Testing_for_peanuts_allergy_allergic_to_something_but_not_peanuts()
    {
        var sut = new AllergiesMy(5);
        Assert.False(sut.IsAllergicTo(Allergens.Peanuts));
    }

    [Fact]
    public void Testing_for_peanuts_allergy_allergic_to_everything()
    {
        var sut = new AllergiesMy(255);
        Assert.True(sut.IsAllergicTo(Allergens.Peanuts));
    }

    [Fact]
    public void Testing_for_shellfish_allergy_not_allergic_to_anything()
    {
        var sut = new AllergiesMy(0);
        Assert.False(sut.IsAllergicTo(Allergens.Shellfish));
    }

    [Fact]
    public void Testing_for_shellfish_allergy_allergic_only_to_shellfish()
    {
        var sut = new AllergiesMy(4);
        Assert.True(sut.IsAllergicTo(Allergens.Shellfish));
    }

    [Fact]
    public void Testing_for_shellfish_allergy_allergic_to_shellfish_and_something_else()
    {
        var sut = new AllergiesMy(14);
        Assert.True(sut.IsAllergicTo(Allergens.Shellfish));
    }

    [Fact]
    public void Testing_for_shellfish_allergy_allergic_to_something_but_not_shellfish()
    {
        var sut = new AllergiesMy(10);
        Assert.False(sut.IsAllergicTo(Allergens.Shellfish));
    }

    [Fact]
    public void Testing_for_shellfish_allergy_allergic_to_everything()
    {
        var sut = new AllergiesMy(255);
        Assert.True(sut.IsAllergicTo(Allergens.Shellfish));
    }

    [Fact]
    public void Testing_for_strawberries_allergy_not_allergic_to_anything()
    {
        var sut = new AllergiesMy(0);
        Assert.False(sut.IsAllergicTo(Allergens.Strawberries));
    }

    [Fact]
    public void Testing_for_strawberries_allergy_allergic_only_to_strawberries()
    {
        var sut = new AllergiesMy(8);
        Assert.True(sut.IsAllergicTo(Allergens.Strawberries));
    }

    [Fact]
    public void Testing_for_strawberries_allergy_allergic_to_strawberries_and_something_else()
    {
        var sut = new AllergiesMy(28);
        Assert.True(sut.IsAllergicTo(Allergens.Strawberries));
    }

    [Fact]
    public void Testing_for_strawberries_allergy_allergic_to_something_but_not_strawberries()
    {
        var sut = new AllergiesMy(20);
        Assert.False(sut.IsAllergicTo(Allergens.Strawberries));
    }

    [Fact]
    public void Testing_for_strawberries_allergy_allergic_to_everything()
    {
        var sut = new AllergiesMy(255);
        Assert.True(sut.IsAllergicTo(Allergens.Strawberries));
    }

    [Fact]
    public void Testing_for_tomatoes_allergy_not_allergic_to_anything()
    {
        var sut = new AllergiesMy(0);
        Assert.False(sut.IsAllergicTo(Allergens.Tomatoes));
    }

    [Fact]
    public void Testing_for_tomatoes_allergy_allergic_only_to_tomatoes()
    {
        var sut = new AllergiesMy(16);
        Assert.True(sut.IsAllergicTo(Allergens.Tomatoes));
    }

    [Fact]
    public void Testing_for_tomatoes_allergy_allergic_to_tomatoes_and_something_else()
    {
        var sut = new AllergiesMy(56);
        Assert.True(sut.IsAllergicTo(Allergens.Tomatoes));
    }

    [Fact]
    public void Testing_for_tomatoes_allergy_allergic_to_something_but_not_tomatoes()
    {
        var sut = new AllergiesMy(40);
        Assert.False(sut.IsAllergicTo(Allergens.Tomatoes));
    }

    [Fact]
    public void Testing_for_tomatoes_allergy_allergic_to_everything()
    {
        var sut = new AllergiesMy(255);
        Assert.True(sut.IsAllergicTo(Allergens.Tomatoes));
    }

    [Fact]
    public void Testing_for_chocolate_allergy_not_allergic_to_anything()
    {
        var sut = new AllergiesMy(0);
        Assert.False(sut.IsAllergicTo(Allergens.Chocolate));
    }

    [Fact]
    public void Testing_for_chocolate_allergy_allergic_only_to_chocolate()
    {
        var sut = new AllergiesMy(32);
        Assert.True(sut.IsAllergicTo(Allergens.Chocolate));
    }

    [Fact]
    public void Testing_for_chocolate_allergy_allergic_to_chocolate_and_something_else()
    {
        var sut = new AllergiesMy(112);
        Assert.True(sut.IsAllergicTo(Allergens.Chocolate));
    }

    [Fact]
    public void Testing_for_chocolate_allergy_allergic_to_something_but_not_chocolate()
    {
        var sut = new AllergiesMy(80);
        Assert.False(sut.IsAllergicTo(Allergens.Chocolate));
    }

    [Fact]
    public void Testing_for_chocolate_allergy_allergic_to_everything()
    {
        var sut = new AllergiesMy(255);
        Assert.True(sut.IsAllergicTo(Allergens.Chocolate));
    }

    [Fact]
    public void Testing_for_pollen_allergy_not_allergic_to_anything()
    {
        var sut = new AllergiesMy(0);
        Assert.False(sut.IsAllergicTo(Allergens.Pollen));
    }

    [Fact]
    public void Testing_for_pollen_allergy_allergic_only_to_pollen()
    {
        var sut = new AllergiesMy(64);
        Assert.True(sut.IsAllergicTo(Allergens.Pollen));
    }

    [Fact]
    public void Testing_for_pollen_allergy_allergic_to_pollen_and_something_else()
    {
        var sut = new AllergiesMy(224);
        Assert.True(sut.IsAllergicTo(Allergens.Pollen));
    }

    [Fact]
    public void Testing_for_pollen_allergy_allergic_to_something_but_not_pollen()
    {
        var sut = new AllergiesMy(160);
        Assert.False(sut.IsAllergicTo(Allergens.Pollen));
    }

    [Fact]
    public void Testing_for_pollen_allergy_allergic_to_everything()
    {
        var sut = new AllergiesMy(255);
        Assert.True(sut.IsAllergicTo(Allergens.Pollen));
    }

    [Fact]
    public void Testing_for_cats_allergy_not_allergic_to_anything()
    {
        var sut = new AllergiesMy(0);
        Assert.False(sut.IsAllergicTo(Allergens.Cats));
    }

    [Fact]
    public void Testing_for_cats_allergy_allergic_only_to_cats()
    {
        var sut = new AllergiesMy(128);
        Assert.True(sut.IsAllergicTo(Allergens.Cats));
    }

    [Fact]
    public void Testing_for_cats_allergy_allergic_to_cats_and_something_else()
    {
        var sut = new AllergiesMy(192);
        Assert.True(sut.IsAllergicTo(Allergens.Cats));
    }

    [Fact]
    public void Testing_for_cats_allergy_allergic_to_something_but_not_cats()
    {
        var sut = new AllergiesMy(64);
        Assert.False(sut.IsAllergicTo(Allergens.Cats));
    }

    [Fact]
    public void Testing_for_cats_allergy_allergic_to_everything()
    {
        var sut = new AllergiesMy(255);
        Assert.True(sut.IsAllergicTo(Allergens.Cats));
    }

    [Fact]
    public void No_allergies()
    {
        var sut = new AllergiesMy(0);
        Assert.Empty(sut.List());
    }

    [Fact]
    public void Just_eggs()
    {
        var sut = new AllergiesMy(1);
        var expected = new[] { Allergens.Eggs };
        Assert.Equal(expected, sut.List());
    }

    [Fact]
    public void Just_peanuts()
    {
        var sut = new AllergiesMy(2);
        var expected = new[] { Allergens.Peanuts };
        Assert.Equal(expected, sut.List());
    }

    [Fact]
    public void Just_strawberries()
    {
        var sut = new AllergiesMy(8);
        var expected = new[] { Allergens.Strawberries };
        Assert.Equal(expected, sut.List());
    }

    [Fact]
    public void Eggs_and_peanuts()
    {
        var sut = new AllergiesMy(3);
        var expected = new[] { Allergens.Eggs, Allergens.Peanuts };
        Assert.Equal(expected, sut.List());
    }

    [Fact]
    public void More_than_eggs_but_not_peanuts()
    {
        var sut = new AllergiesMy(5);
        var expected = new[] { Allergens.Eggs, Allergens.Shellfish };
        Assert.Equal(expected, sut.List());
    }

    [Fact]
    public void Lots_of_stuff()
    {
        var sut = new AllergiesMy(248);
        var expected = new[] { Allergens.Strawberries, Allergens.Tomatoes, Allergens.Chocolate, Allergens.Pollen, Allergens.Cats };
        Assert.Equal(expected, sut.List());
    }

    [Fact]
    public void Everything()
    {
        var sut = new AllergiesMy(255);
        var expected = new[] { Allergens.Eggs, Allergens.Peanuts, Allergens.Shellfish, Allergens.Strawberries, Allergens.Tomatoes, Allergens.Chocolate, Allergens.Pollen, Allergens.Cats };
        Assert.Equal(expected, sut.List());
    }

    [Fact]
    public void No_allergen_score_parts()
    {
        var sut = new AllergiesMy(509);
        var expected = new[] { Allergens.Eggs, Allergens.Shellfish, Allergens.Strawberries, Allergens.Tomatoes, Allergens.Chocolate, Allergens.Pollen, Allergens.Cats };
        Assert.Equal(expected, sut.List());
    }
}
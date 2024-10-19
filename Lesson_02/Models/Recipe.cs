using System;

namespace Lesson_02.Models;

public class Recipe
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<string> Ingredients { get; set; }
    public int PrepTimeInMinute { get; set; }
    public int CaloriesForOneBowl { get; set; }

    public Recipe(string name, string description, List<string> ingredients, int prepTimeInMinute, int calories)
    {
        Name = name;
        Description = description;
        Ingredients = ingredients;
        PrepTimeInMinute = prepTimeInMinute;
        CaloriesForOneBowl = calories;
    }
}
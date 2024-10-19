using Lesson_02.Models;

Console.WriteLine("Hello, World!");

var recipes = new List<Recipe>
{
    new Recipe(
        "Kuru Fasulye",
        "Traditional Turkish white bean stew, usually served with rice.",
        new List<string> { "White beans", "Onion", "Tomato paste", "Olive oil", "Salt", "Pepper", "Water" },
        90,
        300
    ),

    new Recipe(
        "İmam Bayıldı",
        "A classic Turkish dish made with eggplants stuffed with onions, tomatoes, and garlic.",
        new List<string> { "Eggplant", "Onion", "Tomato", "Garlic", "Olive oil", "Salt", "Pepper" },
        60,
        250
    ),

    new Recipe(
        "Mercimek Çorbası",
        "A hearty lentil soup that is a staple of Turkish cuisine.",
        new List<string> { "Red lentils", "Carrot", "Potato", "Onion", "Olive oil", "Salt", "Pepper", "Water" },
        40,
        150
    ),

    new Recipe(
        "Lahmacun",
        "A thin and crispy Turkish flatbread topped with a minced meat mixture.",
        new List<string> { "Flour", "Minced meat", "Onion", "Tomato", "Garlic", "Parsley", "Spices", "Salt" },
        30,
        400
    ),

    new Recipe(
        "Manti",
        "Turkish dumplings filled with ground meat, served with yogurt and garlic sauce.",
        new List<string> { "Flour", "Egg", "Minced meat", "Yogurt", "Garlic", "Butter", "Red pepper flakes" },
        120,
        500
    ),

    new Recipe(
        "Dolma",
        "Grape leaves stuffed with a rice and herb mixture, sometimes with ground meat.",
        new List<string> { "Grape leaves", "Rice", "Onion", "Tomato", "Parsley", "Dill", "Olive oil", "Salt" },
        90,
        220
    ),

    new Recipe(
        "Menemen",
        "A simple yet delicious Turkish scrambled egg dish with tomatoes and peppers.",
        new List<string> { "Eggs", "Tomato", "Green pepper", "Olive oil", "Salt", "Pepper" },
        20,
        200
    ),

    new Recipe(
        "Baklava",
        "A rich, sweet pastry made of layers of filo filled with chopped nuts and sweetened with syrup or honey.",
        new List<string> { "Filo pastry", "Pistachios", "Butter", "Sugar", "Water", "Lemon juice" },
        180,
        400
    ),

    new Recipe(
        "Simit",
        "A circular bread covered with sesame seeds, often eaten for breakfast in Turkey.",
        new List<string> { "Flour", "Yeast", "Water", "Molasses", "Sesame seeds" },
        60,
        250
    ),

    new Recipe(
        "Tavuk Göğsü",
        "A Turkish milk pudding made with chicken breast and sugar, a unique dessert.",
        new List<string> { "Chicken breast", "Milk", "Sugar", "Rice flour", "Cornstarch", "Butter", "Cinnamon" },
        60,
        300
    )
};

Console.WriteLine($"{recipes[0].Name}");
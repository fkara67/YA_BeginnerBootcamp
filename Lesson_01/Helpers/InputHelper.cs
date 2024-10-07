using System;

namespace Lesson_01.Helpers;

public static class InputHelper
{
    public static string GetInput(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine();
    }

    public static string GetTextOnlyInput(string message)
    {
        string textInput = "";

        while (true)
        {
            textInput = GetInput(message);

            bool isTextValid = TextHelper.IsTextValid(textInput);

            if (!isTextValid)
                Console.WriteLine("This input can only contain text!");
            else
                break;
        }

        return textInput;
    }

    public static string GetNumberOnlyInput(string message)
    {
        string numberInput = "";

        while (true)
        {
            numberInput = GetInput(message);

            bool isNumberValid = TextHelper.IsDigit(numberInput);

            if (!isNumberValid)
                Console.WriteLine("This input can only contain numbers!");
            else
                break;
        }

        return numberInput;
    }
}
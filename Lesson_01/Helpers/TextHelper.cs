using System;

namespace Lesson_01.Helpers;

public static class TextHelper
{
    public static bool IsDigit(string text)
    {
        bool isTextValid = true;

        for (int i = 0; i < text.Length; i++)
        {
            if (!char.IsDigit(text[i]))
            {
                isTextValid = false;
                break;
            }
        }

        return isTextValid;
    }

    public static bool IsTextValid(string text)
    {
        bool isTextValid = true;

        for (int i = 0; i < text.Length; i++)
        {
            if (!char.IsLetter(text[i]))
            {
                isTextValid = false;
                break;
            }
        }

        return isTextValid;
    }
}
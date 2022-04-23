using System.Globalization;

namespace TextAnalyzer.Extensions;

public static class StringExtensions
{
    public static int WordNumber(this string? text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return 0;

        text = text.Trim();

        var index = 0;
        var count = 1;
        
        while (index <= text.Length - 1)
        {
            if (text[index] == ' ' || text[index] == '\n' || text[index] == '\t')
            {
                count++;
            }
            index++;
        }

        return count;
    }
    
    public static string? Capitalize(this string? text)
    {
        return string.IsNullOrWhiteSpace(text) ? text : CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text);
    }

    public static bool IsPalindrome(this string? text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return false;
        
        text = text.Trim().ToLower().Replace(" ", String.Empty);
        char[] arr = text.ToCharArray();
        
        Array.Reverse(arr);
        
        var temp = new string(arr);

        return text.Equals(temp);
    }

    public static Dictionary<string, int>? WordFrequency(this string? text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return null;

        text = text.Trim().ToLower();
        var temp = text.Split(' '); 
        
        var dictionary = new Dictionary<string, int>();  
        foreach (var item in temp)
        {
            if (dictionary.ContainsKey(item))   
            {  
                int value = dictionary[item];  
                dictionary[item] = value + 1;  
            }  
            else  
            {  
                dictionary.Add(item, 1);     
            }
        }

        return dictionary;
    }
}
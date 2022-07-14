using System;
using System.Collections.Generic;


namespace ScrabbleScore.Models
{
  
  public class Scrabble
  {
    public string Description { get; set; }

    public static Dictionary<string, int> letters = new Dictionary<string, int>() {
      {"A", 1}, {"E", 1}, {"I", 1}, {"O", 1}, {"U", 1}, {"L", 1}, {"N", 1}, {"R", 1}, {"S", 1}, {"T", 1}, {"D", 2}, {"G", 2}, {"B", 3}, {"C", 3}, {"M", 3}, {"P", 3}, {"F", 4}, {"H", 4}, {"V", 4}, {"W", 4}, {"Y", 4}, {"K", 5}, {"J", 8}, {"X", 8}, {"Q", 10}, {"Z", 10}
    };
    
    // public static Dictionary<char, int> GetAll()
    // {
    //   return letters;
    // }

    public Scrabble(string description)
    {
      Description = description.ToUpper();
      // Letters = letters;
      // letters.Add(this);
    }
    // public static string GetValue()
    // {
    //   foreach (KeyValuePair<string, int> element in letters)
    //   {
    //     return Console.WriteLine("Key: {0}, Value: {1}", element.Key, element.Value);
    //   }
    // }
  }
}
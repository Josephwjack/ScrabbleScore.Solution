using System;
using System.Collections.Generic;
using ScrabbleScore.Models;


namespace ScrabbleScore
{
  public class Program
  {
    public static void Main() 
    {
    Console.WriteLine("Type in a word");
    string description = Console.ReadLine();
    Scrabble newScrabble = new Scrabble(description);
    string result = newScrabble.Description;
    // char[] uInput = userInput.ToCharArray();
    // Console.WriteLine(uInput);
    // Console.WriteLine(Scrabble.letters["G"]);
    // Scrabble.GetValue();
    Scrabble.IsPalindrome(result);
//Pneumonoultramicroscopicsilicovolcanoconiosis
    
    }
  }
}
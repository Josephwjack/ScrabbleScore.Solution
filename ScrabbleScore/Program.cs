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
    Scrabble.IsPalindrome(result);
    }
  }
}
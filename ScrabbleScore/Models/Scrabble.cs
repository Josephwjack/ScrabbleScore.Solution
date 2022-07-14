using System;

namespace ScrabbleScore.Models
{
  
  public class Scrabble
  {
    public string Description { get; set; }

    public Scrabble(string description)
    {
      Description = description;
    }
  }
}
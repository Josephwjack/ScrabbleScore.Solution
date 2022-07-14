using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleTests // : IDisposable
  {
    // public void Dispose()
    // {
    //   ClassName.ClearAll();
    // }

    [TestMethod]
    public void ScrabbleConstructor_CreateInstanceOfScrabble_Scrabble()
    {
      Scrabble newScrabble = new Scrabble("word");
      Assert.AreEqual(typeof(Scrabble), newScrabble.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string description = "word";
      Scrabble newScrabble = new Scrabble(description);
      string result = newScrabble.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "word";
      Scrabble newScrabble = new Scrabble(description);
      string updatedDescription = "word";
      newScrabble.Description = updatedDescription;
      string result = newScrabble.Description;
      Assert.AreEqual(updatedDescription, result);
    }
  }
}
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
      Scrabble newScrabble = new Scrabble();
      Assert.AreEqual(typeof(Scrabble), newScrabble.GetType());
    }
  }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void CountTheWords_NumberOfWords()
    {
      //Arrange
      string input = "Mochi";
      string output = "Mochi is my favorite icecream";
      int count = 1;

      // Act
      int result = RepeatCounter.CountTheWords(input, RepeatCounter.SplitTheText(output));

      //Assert
      Assert.AreEqual(count, result);
    }
  }
}

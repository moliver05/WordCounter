using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest : IDisposable
  {
    [TestMethod]
    public void GetInput_ReturnsInput_String()
    {
      //Arrange
      string input = "Mochi";
      RepeatCounter newRepeatCounter = new RepeatCounter(input);

      // Act
      string result = newRepeatCounter.GetInput();

      //Assert
      Assert.AreEqual(input, result);
    }
    [TestMethod]
    public void SetInput_GetInput_String()
    {
      // Arrange
      string input = "Macbook";
      RepeatCounter newRepeatCounter = new RepeatCounter(input);

      // Act
      string secondDescription = "Microsoft";
      newRepeatCounter.SetInput(secondDescription);
      string result = newRepeatCounter.GetInput();

      // Assert
      Assert.AreEqual(secondDescription, result);
    }
    [TestMethod]
    public void CountTheWords()
    {
      // Arrange
      string count = "numbers";
      string countChar[] = new countChar(count);

       // Act
       string secoundCount = "numbersxtwo"
       newcountChar.SetInput(secondCount);
       string result = newcountChar.GetInput();

       // Assert
      Assert.AreEqual(secondCount, result)
    }
    public void Dispose()
    {
      RepeatCounter.ClearAll();
    }
  }
}

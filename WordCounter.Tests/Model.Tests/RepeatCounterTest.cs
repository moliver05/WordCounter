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
    public void Dispose()
    {
      RepeatCounter.ClearAll();
    }
  }
}

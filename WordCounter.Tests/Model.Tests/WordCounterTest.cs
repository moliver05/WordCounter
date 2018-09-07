using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest : IDisposable
  {
    [TestMethod]
    public void GetMeaning_ReturnsMeaning_String()
    {
      //Arrange
      string meaning = "Mochi";
      RepeatCounter newRepeatCounter = new RepeatCounter(meaning);

      // Act
      string result = newRepeatCounter.GetMeaning();

      //Assert
      Assert.AreEqual(meaning, result);
    }
    [TestMethod]
    public void SetMeaning_GetMeaning_String()
    {
      // Arrange
      string description = "Macbook";
      RepeatCounter newRepeatCounter = new RepeatCounter(description);

      // Act
      string secondDescription = "Microsoft";
      newRepeatCounter.SetMeaning(secondDescription);
      string result = newRepeatCounter.GetMeaning();

      // Assert
      Assert.AreEqual(secondDescription, result);
    }

    [TestMethod]
    public void Save_RepeatCounterisSavedToData_RepeatCounter()
    {
      // Arrange
      string description = "Mochi";
      RepeatCounter newRepeatCounter = new RepeatCounter(description);
      newRepeatCounter.Save();

      // Act
      List<RepeatCounter> data = RepeatCounter.GetAll();
      RepeatCounter savedRepeatCounter = data[0];

      // Assert
      Assert.AreEqual(newRepeatCounter, savedRepeatCounter);

    }
    [TestMethod]
    public void GetData_ReturnsRepeatCounter_RepeatCounterList()
    {
      // Arrange
      string description1 = "Mochi";
      string  description2 = "Macbook";
      RepeatCounter newRepeatCounter1 = new RepeatCounter(description1);
      newRepeatCounter1.Save();
      RepeatCounter newRepeatCounter2 = new RepeatCounter(description2);
      newRepeatCounter2.Save();
      RepeatCounter newRepeatCounter = new List<RepeatCounter> { newRepeatCounter1, newRepeatCounter2 };

      // Act
      List<RepeatCounter> result = RepeatCounter.GetAll();

      // Assert
      CollectionAssert.AreEqual(newRepeatCounter, result);
    }

    public void Dispose()
    {
      RepeatCounter.ClearAll();
    }
  }
}

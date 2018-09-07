using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _meaning;
    private static List<RepeatCounter> _data = new List<RepeatCounter> {};

    public RepeatCounter (string meaning)
    {
      _meaning = meaning;
    }
    public string GetMeaning()
    {
      return _meaning;
    }
    public void SetMeaning(string newMeaning)
    {
      _meaning = newMeaning;
    }
    public static List<RepeatCounter> GetAll()
    {
      return _data;
    }
    public void Save()
    {
      _data.Add(this);
    }
    public static void ClearAll()
    {
      _data.Clear();
    }

  }

  public class program
  {
    public static void Main ()
  {
    Console.WriteLine("Welcome to WordCounter Program");
    Console.WriteLine("Please Choose to Add words or Search (Add/Search)");
    string response = Console.ReadLine();

  if (response == "Add")
  {
    Console.WriteLine ("Please Input Words:");
    string wordInput = Console.ReadLine();
    RepeatCounter newRepeatCounter = new RepeatCounter(wordInput);
    newRepeatCounter.Save();

    Console.WriteLine (wordInput +  " has beed added, you can now View the input word");
    Main();
  }

  else if (response == "Search")
  {
    List<RepeatCounter> data = RepeatCounter.GetAll();
    for (int i = 0; i < data.Count; i++)
    {
      string searchedMeaning= data[i].GetMeaning();
      Console.WriteLine((i + 1) + ". " + searchedMeaning);
    }
    Main();

  }
  else
  {
    Console.WriteLine("Tired? Type 'Quit' to end Program if not press enter to continue.");
    if (Console.ReadLine() != "quit")
    {
    Main();
    }
   }
  }
 }
}
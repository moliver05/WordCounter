using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _text;
    private string _input;

    public void SetPrivateInput(string input)
    {
      _input = input;
    }

    public string GetPrivateInput()
    {
      return _input;

    }

    public void SetPrivateText(string text)
    {
      _text = text;
    }

    public string GetPrivateText()
    {
      return _text;

    }

    public char[] SplittheInput()
    {
    char[] splitInput = _input.Split(' ');
    return splitInput;
    }

    public int Count()
    {
      int counts = 0;
      foreach(string text in SplitSentence())
     {
    if (words.Equals(_text))
      {
       counts ++;
      }
       return _text;
      }
    }
  }

  public class Program
  {
      public static void Main()
    {
      Console.WriteLine("Welcome to WordCounter Program");
      Console.WriteLine("Please type in a word");
      // string wordInput = Console.ReadLine();
      // RepeatCounter wordInput = new RepeatCounter();

    }
  }
}

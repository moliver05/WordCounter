using System;


namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _input;
    private string _output;
    private int _count = 0;

    public void SetPrivateStrings(string input, string output)
    {
      _input = input;
      _output = output;
    }
    public void GetPrivateStrings()
    {
      return _input;
      return _output;
    }
    public int CountTheWords(int count)
    {
     _count = count;
     {
      for(int i = 0; i < output.Length + 1; i ++)
        _count += (_input == inputs[i]) ? 1 : 0;
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
     output = 
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
}

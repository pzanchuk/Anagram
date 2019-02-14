using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void CheckAnagram(string word, List<string> words)
  {
    string original = word;
    char[] wordChars = word.ToCharArray();
    Array.Sort(wordChars);

    foreach (string element in words)
    {
      string myElement = element;
      char[] listChars = element.ToCharArray();
      Array.Sort(listChars);
      if(wordChars.SequenceEqual(listChars))
      {
        Console.WriteLine("Your original word is: "+original);
        Console.WriteLine("Anagrams for your word is: "+ myElement);
      }
    }
  }

  public static void Main()
  {

    Console.WriteLine("====================================");
    Console.WriteLine("ANAGRAM CHECKER");
    Console.WriteLine("Enter a word: ");
    string userInputFirst = Console.ReadLine();
    List<string> listOfWords = new List<string>();

    while(true)
    {
      Console.WriteLine("Enter a word to compare? [N to exit] ");
      string userInput = Console.ReadLine();
      listOfWords.Add(userInput);
      if(userInput == "N")
      {
        break;
      }
    }
    CheckAnagram(userInputFirst, listOfWords);
  }
}

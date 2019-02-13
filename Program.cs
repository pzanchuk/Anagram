using System;
using System.Collections.Generic;

namespace MyToDoList
{

  public class Program
  {
    public static void Main()
    {

      Console.WriteLine("====================================");
      Console.WriteLine("Welcome to MyToDoList");
      Console.WriteLine("Would you like to add an item to your list or view your list?( 'A' for Add/ 'V' for View): ");
      string userInput = Console.ReadLine();
      if(userInput == "A" || userInput == "a")
      {
        Console.WriteLine("Please enter the description for the new item.");
        string input = Console.ReadLine();
        Item item = new Item(input);
        Console.WriteLine(item.GetDescription()+" has been added to your list.");
        Main();
      }else{
        List<Item> result = Item.GetAll();

        int i = 1;
        foreach (Item thisItem in result)
        {
          Console.WriteLine((i++) + " thing from your list: "  + thisItem.GetDescription());
        }

      }
    }
  }
}

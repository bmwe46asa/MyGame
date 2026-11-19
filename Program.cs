using System;
using System.Transactions;
namespace Less
{
 internal class Program
 {
    private static void Main(string[] args)
    {
      Console.WriteLine("Enter your name");
      string playerName = Console.ReadLine();
      Console.WriteLine("Welcom " + playerName);
      Console.WriteLine("Enter your age");
      string ageText = Console.ReadLine();  
      bool isNumber = int.TryParse(ageText, out int age);
      if (!isNumber)
      {
        Console.WriteLine("Invalid");
      }
      else if (age < 1 || age > 100)
      {
        Console.WriteLine("false age");
      }
      else
      {
        Console.WriteLine("O my Gad age");
      }

    }
 }
}
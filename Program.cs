using System;
namespace Less
{
 internal class Program
 {
    private static void Main(string[] args)
    {
      int Health = 100;
      int Score = 0;
      bool isAlive = true;
      Console.WriteLine("Enter your name");
      string yourName = Console.ReadLine();
      Console.WriteLine("Welcom " + yourName);
      Console.WriteLine("Your age?");
      string ageText = Console.ReadLine();
      bool isNumber = int.TryParse(ageText, out int age);
      if(!isNumber)
      {
        Console.WriteLine("Invalid age");
      }
      else if(age < 1 ||  age > 100)
      {
        Console.WriteLine("Age out of range");
      }
      else
      {
        Console.WriteLine("Age accepted");
      }
      if ((isNumber) && (age >= 1 && age <= 100))
      {
        Console.WriteLine(yourName);
        Console.WriteLine(Health);
        Console.WriteLine(Score);
        Console.WriteLine(isAlive);
        Console.WriteLine("your damage?");
        string damage = Console.ReadLine();
        bool daNumber = int.TryParse(damage, out int number);
        if ((!daNumber) || number < 0)
        {
          Console.WriteLine("Invalid damage");
        }
        else
        {
          int result = Health - number;
          if (result <= 0)
          {
            Health = 0;
            isAlive = false;
          }
          else
          {
            Health = result;
          }
          Console.WriteLine(Health);
          Console.WriteLine(isAlive);
        }
      }


 }
}
}
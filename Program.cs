using System;
namespace Less
{
 internal class Program
 {
    private static void Main(string[] args)
    {
      Player player1 = new Player();

      player1.Health = 100;
      player1.Score = 0;
      player1.Experience = 0;
      player1.Level = 1;
      player1.IsAlive = true;

      Console.WriteLine("Enter your name");
      string yourName = Console.ReadLine();
      player1.Name = yourName;
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
        Console.WriteLine(player1.Health);
        Console.WriteLine( player1.Score);
        Console.WriteLine(player1.IsAlive);
        Console.WriteLine("your damage?");
        string damage = Console.ReadLine();
        bool daNumber = int.TryParse(damage, out int number);
        if ((!daNumber) || number < 0)
        {
          Console.WriteLine("Invalid damage");
        }
        else
        {
         player1.TakeDamage(number);
         Console.WriteLine(player1.Health);
         Console.WriteLine(player1.IsAlive);
        }
      }


 }
}
}
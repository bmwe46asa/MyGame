using System.Reflection.Metadata;
using System.Security;

internal class Program
{
    private static void Main(string[] args)
    {
      bool isAlive = true;
      bool hasKey = false;
      int score = 600;
      bool hasWeapon = true;
      bool canEnterBattle = isAlive && hasWeapon;
      bool canOpenDoor = hasKey || (score >= 500);
      bool isDead = !isAlive;
      Console.WriteLine(canEnterBattle);
      Console.WriteLine(canOpenDoor);
      Console.WriteLine(isDead);
      Bin/;
      obj/;
    }
}

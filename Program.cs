// This program will simulate combant and healing a player character
// Austen Hernandez
// 5/26/26

using PlayerFile;

public class Program
{
    public static void Main()
    {
        Player player1 = new Player(100);
        Console.WriteLine("Player is in combat");
        player1.TakeDamage(50);
        Console.WriteLine("Health: " + player1.Health);
        player1.Heal(50);
        Console.WriteLine("Health: " + player1.Health);
        player1.Heal(50);
        Console.WriteLine("Health: " + player1.Health);
        player1.TakeDamage(200);
        Console.WriteLine("Health: " + player1.Health);
    }
}

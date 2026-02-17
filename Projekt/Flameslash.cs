using Projekt;

public class Flameslash : Ability
{
    public Flameslash()
    {
        Name = "Flameslash";
    }

    public override void Use(Hero hero, Enemy enemy)
    {
        Console.WriteLine($"Warrior använda Flameslash!");
        enemy.HP -= 15;
    }
}

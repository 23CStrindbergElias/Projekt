using Projekt;

public class Flameslash : Ability
{
    public Flameslash()
    {
        Name = "Flameslash";
        
    }

    public override void Use(Hero hero, Enemy enemy)
    {
        Console.WriteLine($"Warrior använde {Name}");
        hero.MP -= 5;
        enemy.HP -= 15;
    }
}

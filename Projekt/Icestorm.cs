
using Projekt;

public class Icestorm : BossSpells
{
    public Icestorm()
    {
        Name = "Icestorm";
    }

    public override void Use(Enemy enemy, Hero hero)
    {
        Console.WriteLine($"Boss använde {Name}");
        enemy.MP -= 15;
        hero.HP -= 10;
    }
}

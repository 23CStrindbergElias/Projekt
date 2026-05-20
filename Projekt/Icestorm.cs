
using Projekt;

public class Icestorm : BossSpells
{
    // BossSpells, andra namn för att visa att bossen är stark
    public Icestorm()
    {
        Name = "Icestorm";
    }

    // Metod för att boss ska kunna använda på hero. Target är hero
    public override void Use(Enemy enemy, Hero hero)
    {
        Console.WriteLine($"Boss använde {Name}");
        hero.Stats["HP"] -= 10;
    }
}

namespace Projekt;

public class BossSpells
{
    // Namnet av spell
    public string Name;

    // Drar av värden från designerade variabler, fungerar som självaste attacken
    public virtual void Use(Enemy enemy, Hero hero)
    {
        Console.WriteLine($"Boss använde {Name}");
        enemy.MP -= 10;
        hero.Stats["HP"] -= 15;
    }
}

namespace Projekt;

public class BossSpells
{
    public string Name;

    public virtual void Use(Enemy enemy, Hero hero)
    {
        Console.WriteLine($"Boss använde {Name}");
        enemy.MP -= 10;
        hero.Stats["HP"] -= 15;
    }
}

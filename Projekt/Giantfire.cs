using Projekt;

public class Giantfire : BossSpells
{
    // Instans med namn
    public Giantfire()
    {
        Name = "Giantfire";
    }

    // Spell för bossen, target är hero
    public override void Use(Enemy enemy, Hero hero)
    {
        // Liten textbit för att visa vad bossen använde samt avdrag från variabel
        Console.WriteLine($"Boss använde {Name}");
        hero.Stats["HP"] -= 15;
    }
}

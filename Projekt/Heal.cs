public class Heal : DefenceSpells
{
    // Instans med namn
    public Heal()
    {
        Name = "Heal";
    }

    // Defensive spell för target är hero
    public override void Use(Hero hero, Hero target)
    {
        // 10 läggs på HP stat
        Console.WriteLine($"Priest använde Heal!");
        target.Stats["HP"] += 10;        
    }

}


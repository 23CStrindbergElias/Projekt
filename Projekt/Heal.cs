public class Heal : DefenceSpells
{
    public Heal()
    {
        Name = "Heal";
    }

    public override void Use(Hero hero, Hero target)
    {
        Console.WriteLine($"Priest använde Heal!");
    }

}


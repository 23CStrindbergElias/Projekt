using Projekt;

public class Kaboom : OffenseSpells
{
    // Instans med namn i
    public Kaboom()
    {
        Name = "Kaboom";
        
    }

    // Mage kan använda denna, den gör mycket damage för det är en stor explosion. Use är bra för den override:ar andra metoder.
    public override void Use(Hero hero, Enemy enemy)
    {
        Console.WriteLine($"Mage använde Kaboom!");
        enemy.HP -= 20;
        hero.Stats["MP"] -= 10;
    }
}

using Projekt;

public class Kaboom : OffenseSpells
{
    public Kaboom()
    {
        Name = "Kaboom";
        
    }

    public override void Use(Hero hero, Enemy enemy)
    {
        Console.WriteLine($"Mage använde Kaboom!");
        enemy.HP -= 20;
        hero.MP -= 10;
    }
}

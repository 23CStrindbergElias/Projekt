using Projekt;

public class Iceshard : OffenseSpells
{
    public Iceshard()
    {
        Name = "Fireball";
        
    }

    public override void Use(Hero hero, Enemy enemy)
    {
        Console.WriteLine($"Mage använde Iceshard!");
        enemy.HP -= 10;
        hero.MP -= 5;
    }
}

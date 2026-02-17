using Projekt;

public class Fireball : OffenseSpells
{
    public Fireball()
    {
        Name = "Fireball";
        
    }

    public override void Use(Hero hero, Enemy enemy)
    {
        Console.WriteLine($"Mage använda Fireball!");
        enemy.HP -= 15;
    }
}

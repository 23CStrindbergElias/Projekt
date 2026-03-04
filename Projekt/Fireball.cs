using Projekt;

public class Fireball : OffenseSpells
{
    public Fireball()
    {
        Name = "Fireball";
        
    }

    public override void Use(Hero hero, Enemy enemy)
    {
        Console.WriteLine($"{hero} använde Fireball!");
        enemy.HP -= 15;
        hero.MP -= 5;
    }
}

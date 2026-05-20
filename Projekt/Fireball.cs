using Projekt;

public class Fireball : OffenseSpells
{
    // Instans med namn
    public Fireball()
    {
        Name = "Fireball";
        
    }

    // Metod för att använda Fireball på enemy
    public override void Use(Hero hero, Enemy enemy)
    {
        // Bestämmda värden dras av från variabler
        Console.WriteLine($"{hero} använde Fireball!");
        enemy.HP -= 15;
        hero.Stats["MP"] -= 5;
    }
}

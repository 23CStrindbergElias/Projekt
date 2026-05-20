using Projekt;

public class Flameslash : Ability
{
    // Instans med bestämt namn
    public Flameslash()
    {
        Name = "Flameslash";
        
    }

    // Use metod för atta användas på enemy. Enemy är target vilket gör den offensive. 
    public override void Use(Hero hero, Enemy enemy)
    {
        // Bestämda värden dras av från variabler
        Console.WriteLine($"Warrior använde {Name}");
        hero.Stats["MP"] -= 5;
        enemy.HP -= 15;
    }
}

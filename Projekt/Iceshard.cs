using Projekt;

public class Iceshard : OffenseSpells
{
    // Ny instans samt namn på spell
    public Iceshard()
    {
        Name = "Iceshard";
        
    }

    // metod för att använda spell på enemy, det är offensive vilket gör att target är enemy. 
    public override void Use(Hero hero, Enemy enemy)
    {
        // Värden dras av från variabler
        Console.WriteLine($"Mage använde Iceshard!");
        enemy.HP -= 10;
        hero.Stats["MP"] -= 5;
    }
}

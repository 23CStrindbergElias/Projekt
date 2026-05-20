using Projekt;

public class NormalAttack : Ability
{
    // Instans med namn
    public NormalAttack()
    {
        Name = "Normal Attack";
        
    }

    // Override metod där Hero använder den på enemy
    public override void Use(Hero hero, Enemy enemy)
    {
        // Hero AP i dictionary dras av enemy.HP, det är effektivt att använda dictionary för att lagras
        Console.WriteLine($"{hero} använde Normal Attack!");
        enemy.HP -= hero.Stats["AP"];
    }
}

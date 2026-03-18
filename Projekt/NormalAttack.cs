using Projekt;

public class NormalAttack : Ability
{
    public NormalAttack()
    {
        Name = "Normal Attack";
        
    }

    public override void Use(Hero hero, Enemy enemy)
    {
        Console.WriteLine($"{hero} använde Normal Attack!");
        enemy.HP -= hero.AP;
    }
}

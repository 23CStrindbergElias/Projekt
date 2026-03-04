using Projekt;

public class NormalAttack : Ability
{
    public NormalAttack()
    {
        Name = "Flameslash";
        
    }

    public override void Use(Hero hero, Enemy enemy)
    {
        Console.WriteLine($"Warrior använda Flameslash!");
        enemy.HP -= 10;
    }
}

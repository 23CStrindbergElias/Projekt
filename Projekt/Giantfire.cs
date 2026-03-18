using Projekt;

public class Giantfire : BossSpells
{
    public Giantfire()
    {
        Name = "Giantfire";
    }

    public override void Use(Enemy enemy, Hero hero)
    {
        Console.WriteLine($"Boss använde {Name}");
        enemy.MP -= 10;
        hero.HP -= 15;
    }
}

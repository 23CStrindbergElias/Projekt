using Projekt;

public class Boss : Enemy
{
    public List<BossSpells> bossSpells = [];
    public Boss()
    {
        Name = "Boss";
        HP = 700;
        AP = 20;
        MP = 50;

        bossSpells.Add(new Giantfire());
        bossSpells.Add(new Icestorm());
    }

    public void BossTurn(Hero hero)
    {
        int r = Random.Shared.Next(0, bossSpells.Count);
        bossSpells[r].Use(this, hero);
        Console.WriteLine($"Bossen använde {bossSpells[r].Name} på {hero.Name}");
        Console.WriteLine($"{hero.Name} har nu {hero.HP} kvar!");
        Console.WriteLine("Klicka ENTER för att fortsätta:");
        Console.ReadLine();
    }
    
}
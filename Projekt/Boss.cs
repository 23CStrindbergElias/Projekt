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
}
public class Mage : Hero
{
    public Mage()
    {
        description = "The Mage is skilled in magical combat. He excells in offensive magic. He may also attack using is wand, although not that effective.";
        Name = "Mage";
        HP = 30;
        AP = 15;
        MP = 100;

        OffenseSpells.Add(new Fireball()); 
        OffenseSpells.Add(new Iceshard()); 
        OffenseSpells.Add(new Kaboom()); 
    }


}
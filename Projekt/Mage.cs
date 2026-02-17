using System.Security.Cryptography.X509Certificates;
using Projekt;

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
        // DefenceSpells.Add("Iceshard");
        // DefenceSpells.Add("Kaboom");
    }


}
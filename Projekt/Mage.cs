public class Mage : Hero
{
    public Mage()
    {
        // En description för att visa för spelaren vad karaktären är bra på samt namn under
        // description = "The Mage is skilled in magical combat. He excells in offensive magic. He may also attack using is wand, although not that effective.";
        Name = "Mage";

        // Dictionary används för att underlätta när värden läggs till, lättare att lagra
        Stats.Add("HP", 100);
        Stats.Add("AP", 15);
        Stats.Add("MP", 100);

        // Offensivespells läggs till i en lista, det är ett bra sätt att lagra 
        OffenseSpells.Add(new Fireball()); 
        OffenseSpells.Add(new Iceshard()); 
        OffenseSpells.Add(new Kaboom()); 

        // Precis som med Offensivespells lagras denna i en lista eftersomd det är effektivt
        Abilities.Add(new NormalAttack());
    }


}
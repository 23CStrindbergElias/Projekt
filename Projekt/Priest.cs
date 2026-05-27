using Projekt;

public class Priest : Hero
{
    public Priest()
    {
        // Kort description om valet av karaktär 
        // description = "The Priest is a defensive focused character. He's focused around healing and buffing his fellow member of the party.";
        Name = "Priest";

        // Lägger till i dictionary som heter Stats, ser mer snyggt ut och lagrar information bra
        Stats.Add("HP", 100);
        Stats.Add("AP", 5);
        Stats.Add("MP", 60);

        // Lägger till heal i DefenceSpells listan, den finns sedan ingame när man väl kör spelet 
        DefenceSpells.Add(new Heal()); 

        // Alla har normalattack, om man har för lite MP kan man använda denna.
        Abilities.Add(new NormalAttack());
    }
}
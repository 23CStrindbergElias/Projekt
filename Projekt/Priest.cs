using Projekt;

public class Priest : Hero
{
    public Priest()
    {
        description = "The Priest is a defensive focused character. He's focused around healing and buffing his fellow member of the party.";
        Name = "Priest";

        Stats.Add("HP", 100);
        Stats.Add("AP", 5);
        Stats.Add("MP", 60);

        DefenceSpells.Add(new Heal()); 

        Abilities.Add(new NormalAttack());
    }
}
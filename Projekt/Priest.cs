using Projekt;

public class Priest : Hero
{
    public Priest()
    {
        description = "The Priest is a defensive focused character. He's focused around healing and buffing his fellow member of the party.";
        Name = "Priest";
        HP = 40;
        AP = 5;
        MP = 60;

        DefenceSpells.Add(new Heal()); 

        // Ability.Add(new Zing());

    }
}
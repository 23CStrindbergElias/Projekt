public class Priest : Hero
{
    public Priest()
    {
        description = "The Priest is a defensive focused character. He's focused around healing and buffing his fellow member of the party.";
        Name = "Priest";
        HP = 40;
        AP = 5;
        MP = 60;

        Spells.Add("Heal"); 
        Spells.Add("Buff");

        Abilities.Add("Zing");

    }
}
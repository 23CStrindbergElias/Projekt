public class Warrior: Hero
{
    public Warrior()
    {
        description = "The warrior is an allround useful character for all situation. He has a balance of good HP and high AP. A must for any party.";
        Name = "Warrior";
        HP = 100;
        AP = 10;
        MP = 40;

        Abilities.Add(new Flameslash());

        // DefenceSpells.Add(new Fireball);

        

    }    


}
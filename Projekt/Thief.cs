public class Thief : Hero
{
    public Thief()
    {
        description = "The Thief is a skilled and agile person. He has a high damage output while also having a small chance to dodge incoming attacks.";
        Name = "Thief";
        HP = 30;
        AP = 25;
        MP = 10;

        Spells.Add("Agility");

        Abilities.Add("Assasins_Strike");

    }    
}
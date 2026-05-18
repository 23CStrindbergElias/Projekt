public class Warrior: Hero
{
    public Warrior()
    {
        description = "The warrior is an allround useful character for all situation. He has a balance of good HP and high AP. A must for any party.";
        Name = "Warrior";


        Stats.Add("HP", 100);
        Stats.Add("AP", 10);
        Stats.Add("MP", 40);


        Abilities.Add(new Flameslash());
        Abilities.Add(new NormalAttack());

        OffenseSpells.Add(new Fireball());

        
    }    
}
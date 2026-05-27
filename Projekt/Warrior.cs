public class Warrior : Hero
{
    public Warrior()
    {
        // Kort description om valet av karaktär 
        string description123;

        SetDesc("The warrior is an allround useful character for all situation. He has a balance of good HP and high AP. A must for any party.");
        
        description123 = GetDesc();
        
        
        
        Name = "Warrior";

        // Lägger till i dictionary som heter Stats, ser mer snyggt ut och lagrar information bra
        Stats.Add("HP", 100);
        Stats.Add("AP", 10);
        Stats.Add("MP", 40);

        // Lägger till Flameslash och NormalAttack i Abilities listan, den finns sedan ingame när man väl kör spelet 
        Abilities.Add(new Flameslash());
        Abilities.Add(new NormalAttack());

        // Lägger till Fireball i OffenseSpells listan
        OffenseSpells.Add(new Fireball());


    }
}
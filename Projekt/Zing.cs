public class Zing : FriendlyAbility
{
    // Namn sätts
    public Zing()
    {
        Name = "Zing";
    }

    // Override med hero som target
    public override void Use(Hero hero, Hero target)
    {
        Console.WriteLine($"Priest använde Zing!");
                
    }
}

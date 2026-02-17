public class Zing : FriendlyAbility
{
    public Zing()
    {
        Name = "Zing";
    }

    public override void Use(Hero hero, Hero target)
    {
        Console.WriteLine($"Priest använde Zing!");
        // Console.WriteLine($"Vem vill du använda Zing på? {}");
        
    }
}

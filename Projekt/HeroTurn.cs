public class HeroTurn
{
    // En klass för heros turn. Denna finns här för att minska koden i Hero och göra det mer komprimerat
    public void HerosTurn(Hero hero, Boss boss)
    {
        // Säger vems turn det är och skriver relecant fakta för spelaren. Detta finns med i Dragon quest ch underlättar underbossfight
        Console.WriteLine($"Det är nu {hero.Name}s tur");
        Console.WriteLine($"Stats för {hero}: MP = {hero.Stats["MP"]}, HP = {hero.Stats["HP"]}.");
        Console.WriteLine("Vad vill du göra?");
        // Skriver ut vilka moves man kan göra (Attack, Spells, Do nothing)
        hero.ListMoves();
        string Moves = Console.ReadLine();
        Console.Clear();

        // Om man skriver fel tvingas man att skriva rätt, förhindrar krash och ger spelaren en till chans om man råkade skriva fel
        while (!hero.Moves.Contains(Moves))
        {
            Console.Clear();
            Console.WriteLine("Du får inte skriva det. Skriv ett move igen.");
            hero.ListMoves();
            Moves = Console.ReadLine();
        }

        // Move används på boss, gör koden mindre och mer läsbar.
        hero.Do(Moves, boss);
    }
}

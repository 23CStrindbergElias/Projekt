public class HeroTurn
{
    public void HerosTurn(Hero hero, Boss boss)
    {
        Console.WriteLine($"Det är nu {hero.Name}s tur");
        Console.WriteLine($"Stats för {hero}: MP = {hero.MP}, HP = {hero.HP}.");
        Console.WriteLine("Vad vill du göra?");
        hero.ListMoves();
        string Moves = Console.ReadLine();
        Console.Clear();

        while (!hero.Moves.Contains(Moves))
        {
            Console.Clear();
            Console.WriteLine("Du får inte skriva det. Skriv ett move igen.");
            hero.ListMoves();
            Moves = Console.ReadLine();
        }

        hero.Do(Moves, boss);
    }
}

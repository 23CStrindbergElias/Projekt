using Projekt;

public class Bossfight
{
    bool BossFightOver = false;

    public void NewFight(List<Hero> Your_Party)
    {
        Console.WriteLine("Det är dags att slåss mot bossen");
        Console.WriteLine("Klicka på ENTER för att gå vidare:");
        Console.ReadLine();
        Console.Clear();

        Enemy Boss = new Boss();
        while (BossFightOver != true)
        {
            Console.WriteLine($"Bossen har {Boss.HP} HP kvar.");
            for (int i = 0; i < Your_Party.Count(); i++)
            {
                Hero hero = Your_Party[i];
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

                hero.Do(Moves, Boss);

                Console.WriteLine($"Bossen har nu {Boss.HP} HP kvar.");
                Console.WriteLine("Klicka ENTER för att fortsätta.");
                Console.ReadLine();
            }
        }
    }
}

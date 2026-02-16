// FIXA LISTA

// Man kan skriva in tex Warrior två gånger






// Variabler början

using Projekt;

int Party_Size = 0;

string choice;

bool BossFightOver = false;

// Variabler slut



// Listor början

List<Hero> Your_Party = [];

// Listor slut



// Kod början

PartyChooser chooser = new();

Your_Party = chooser.ChooseParty(3);

Enemy Boss = new Boss();



Console.WriteLine("Det är dags att slåss mot bossen");
Console.WriteLine("Klicka på ENTER för att gå vidare:");
Console.ReadLine();
Console.Clear();

while (BossFightOver != true)
{
    for (int i = 0; i < Your_Party.Count(); i++)
    {
        Hero hero = Your_Party[i];
        Console.WriteLine($"Det är nu {hero.Name}s tur");
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

        hero.Do(Moves);

        Console.ReadLine();
    }
}





















Console.ReadLine();

// Kod slut
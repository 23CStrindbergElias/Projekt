using Projekt;

public class Hero
{
    // Allmäna variabler
    public string Name {get; protected set;}

    private string description;

    public void SetDesc(string Beskrivning)
    {
        description = Beskrivning;
        
    }

    public string GetDesc()
    {
        return description;
    }








    // Generiska klasser: list och dictionary
    Dictionary<string, string> HeroName = new Dictionary<string, string>();
    public Dictionary<string, int> Stats = new Dictionary<string, int>();
    public List<string> Moves = ["Attack", "Spells", "Do nothing"];
    public List<DefenceSpells> DefenceSpells = [];
    public List<OffenseSpells> OffenseSpells = [];

    public List<Ability> Abilities = [];

    public List<Hero> Party;

    // Skriver ut listan med alla hero moves
    public void ListMoves()
    {
        for (int i = 0; i < Moves.Count; i++)
        {
            Console.WriteLine($"{i + 1}) {Moves[i]}");
            
        }
    }

    // Alla moves som spelaren kan göra
    public void Do(string thing, Enemy enemy)
    {
        // Attack
        if (thing == "Attack")
        {
            // Räknar upp alla abilities 
            for (int i = 0; i < Abilities.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {Abilities[i].Name}");
            }
            Console.WriteLine("Skriv in en siffra");
            string Siffra = Console.ReadLine();
            int a = 0;

            // Om man skriver in felaktigt
            while (!int.TryParse(Siffra, out a))
            {
                Console.WriteLine($"Du får bara skriva en siffra som motsvarar ett party-member! (1-{Abilities.Count})");
                for (int i = 0; i < Abilities.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {Abilities[i].Name}");
                }
                Console.WriteLine("Skriv in en siffra");
                Siffra = Console.ReadLine();
            }

            // Ifall basklass är friendly 
            if (Abilities[a - 1] is FriendlyAbility)
            {
                for (int i = 0; Party.Count > i; i++)
                {
                    Console.WriteLine(Party[i]);
                }
                // Vem vill du använda tex heal på
                Console.WriteLine("Vem vill du använda din ability på?");
                string s = Console.ReadLine();
                int Val = 0;

                // Om man skriver fel siffra
                while (!int.TryParse(Siffra, out a))
                {
                    Console.WriteLine($"Du får bara skriva en siffra som motsvarar en party member! (1-{Party.Count})");
                    for (int i = 0; i < Party.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}) {Party[i].Name}");
                    }
                    Console.WriteLine("Skriv in en siffra");
                    Siffra = Console.ReadLine();
                }


                Abilities[a - 1].Use(this, Party[Val]);
            }
            else
            {
                Abilities[a - 1].Use(this, enemy);

            }
        }

        // om spelarens val är spells
        if (thing == "Spells")
        {
            // Ifall det finns ett antal defensivespells så räknas de upp 
            if (DefenceSpells.Count > 0)
            {
                for (int i = 0; i < DefenceSpells.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {DefenceSpells[i].Name}");
                }
                Console.WriteLine("Skriv in en siffra");
                string Siffra = Console.ReadLine();
                int a = 0;

                // Ifall man skriver fel
                while (!int.TryParse(Siffra, out a))
                {
                    Console.WriteLine($"Du får bara skriva en siffra som motsvarar en spell! (1-{DefenceSpells.Count})");
                    for (int i = 0; i < DefenceSpells.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}) {DefenceSpells[i].Name}");
                    }
                    Console.WriteLine("Skriv in en siffra");
                    Siffra = Console.ReadLine();
                }

                // Vem man vill välja att använda defence spells
                Console.WriteLine("Välj en av:");

                for (int i = 0; i < Party.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {Party[i]}");
                }

                string s = Console.ReadLine();
                int Val = 0;

                // Om tryparse inte fungerar, tex om man skriver in en bokstav och inte en siffra
                while (!int.TryParse(s, out Val))
                {
                    Console.WriteLine($"Du får bara skriva en siffra som motsvarar en i listan! (1-{Party.Count})");
                    for (int i = 0; i < Party.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}) {Party[i].Name}");
                    }
                    Console.WriteLine("Skriv in en siffra");
                    s = Console.ReadLine();
                }

                DefenceSpells[a - 1].Use(this, Party[Val]);
            }

            // om spelaren skriver offensespells
            if (OffenseSpells.Count > 0)
            {
                // Räknar upp antalet spells
                for (int i = 0; i < OffenseSpells.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {OffenseSpells[i].Name}");
                }
                Console.WriteLine("Skriv in en siffra");
                string Siffra = Console.ReadLine();
                int a = 0;

                // Om spelaren skriver in fel, menat att förhindra krash och ge spelaren en till chans att skriva rätt. Det fortsätter tills spelaren skriver rätt
                while (!int.TryParse(Siffra, out a))
                {
                    Console.WriteLine($"Du får bara skriva en siffra som motsvarar en spell! (1-{OffenseSpells.Count})");
                    for (int i = 0; i < OffenseSpells.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}) {OffenseSpells[i].Name}");
                    }
                    Console.WriteLine("Skriv in en siffra");
                    Siffra = Console.ReadLine();
                }

                OffenseSpells[a - 1].Use(this, enemy);
            }

            // Om man inte har spells så går den vidare till nästa karaktär, detta förhindrar krash 
            else
            {
                Console.WriteLine("Du har inga spells.");
                Console.WriteLine("Klicka ENTER för att fortsätta:");
                Console.ReadLine();
            }
        }

        // Om man inte vill göra något, finns här endast för att det finns i Dragon quest
        if (thing == "Do nothing")
        {
            Console.WriteLine("Du gör inget");
            Console.WriteLine("Klicka ENTER för att fortsätta:");
            Console.ReadLine();
        }
    }
}

using Projekt;

public class Hero
{
    public string Name;
    public int HP;
    public int AP;
    public int MP;

    public string description;

    public List<string> Moves = ["Attack", "Spells", "Do nothing"];
    public List<DefenceSpells> DefenceSpells = [];
    public List<OffenseSpells> OffenseSpells = [];

    public List<Ability> Abilities = [];

    public List<Hero> Party;

    public void ListMoves()
    {
        for (int i = 0; i < Moves.Count; i++)
        {
            Console.WriteLine($"{i + 1}) {Moves[i]}");
        }
    }

    public void Do(string thing, Enemy enemy)
    {
        if (thing == "Attack")
        {

            for (int i = 0; i < Abilities.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {Abilities[i].Name}");
            }
            Console.WriteLine("Skriv in en siffra");
            string Siffra = Console.ReadLine();
            int a = 0;

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

            if (Abilities[a - 1] is FriendlyAbility)
            {
                for (int i = 0; Party.Count > i; i++)
                {
                    Console.WriteLine(Party[i]);
                }
                Console.WriteLine("Vem vill du använda din ability på?");
                string s = Console.ReadLine();
                int Val = 0;

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

        if (thing == "Spells")
        {
            if (DefenceSpells.Count > 0)
            {
                for (int i = 0; i < DefenceSpells.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {DefenceSpells[i].Name}");
                }
                Console.WriteLine("Skriv in en siffra");
                string Siffra = Console.ReadLine();
                int a = 0;

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

                Console.WriteLine("Välj en av:");

                for (int i = 0; i < Party.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {Party[i]}");
                }

                string s = Console.ReadLine();
                int Val = 0;

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

            if (OffenseSpells.Count > 0)
            {
                for (int i = 0; i < OffenseSpells.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {OffenseSpells[i].Name}");
                }
                Console.WriteLine("Skriv in en siffra");
                string Siffra = Console.ReadLine();
                int a = 0;

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

            else
            {
                Console.WriteLine("Du har inga spells.");
                Console.WriteLine("Klicka ENTER för att fortsätta:");
                Console.ReadLine();
            }
        }

        if (thing == "Do nothing")
        {
            Console.WriteLine("Du gör inget");
            Console.WriteLine("Klicka ENTER för att fortsätta:");
            Console.ReadLine();
        }
    }
}

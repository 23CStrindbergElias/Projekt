using Projekt;

public class Hero
{
    public string Name;
    public int HP;
    public int AP;
    public int MP;

    public string description;

    public List<string> Moves = ["Attack", "Defend", "Spells", "Do nothing"];
    public List<DefenceSpells> DefenceSpells = [];
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
            int a = int.Parse(Siffra);

            if (Abilities[a - 1] is FriendlyAbility)
            {
                for (int i = 0; Party.Count > i; i++)
                {
                    Console.WriteLine(Party[i]);
                }
                Console.WriteLine("Vem vill du använda din ability på?");
                string s = Console.ReadLine();
                int Val = int.Parse(s);
                if (Val > Party.Count || Val < 0)
                {
                    
                    while (Val > Party.Count || Val < 0)
                    {
                        Console.WriteLine("Du får varken skriva en siffra som är större eller mindre än Party-Size. (3)");
                        Console.WriteLine("Vem vill du använda din ability på?");
                        s = Console.ReadLine();
                        Val = int.Parse(s);
                        Console.Clear();

                    }
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
            }
        }

        if (thing == "Defend")
        {
            
        }

        if (thing == "Do nothing")
        {
            Console.WriteLine("Du gör inget");
            Console.WriteLine("Klicka ENTER för att fortsätta:");
            Console.ReadLine();

        }
    }


}

public class PartyChooser
{
    List<string> Party_Members = ["Warrior", "Mage", "Priest", "Thief", "Tank"];

    List<Hero> PotentialPartyMembers = [new Warrior(), new Mage(), new Priest(), new Thief(), new Tank()];

    public List<Hero> ChooseParty(int partyMaxSize)
    {
        Console.WriteLine("Välkommen till boss-fighten");
        Console.WriteLine("Klicka ENTER för att gå vidare:");
        Console.ReadLine();
        Console.Clear();
        List<Hero> party = [];
        Console.WriteLine("Det är dags att välja ett party att spela som, du kan välja högst tre personer i ditt party.");
        string choice = "";

        while (party.Count < partyMaxSize)
        {
            Console.WriteLine($"Du kan nu välja mellan: {string.Join(", ", Party_Members)}");
            Console.WriteLine($"Ditt nuvarande party innehåller: {string.Join(", ", party)}");
            Console.WriteLine("Skriv ned vilken medlem du vill lägga till:");
            choice = Console.ReadLine();

            if (!Party_Members.Contains(choice))
            {
                Console.WriteLine("Du får bara välja mellan de valen ovan!");
                Console.WriteLine("Klickan ENTER för att fortsätta vidare:");
                Console.ReadLine();
                Console.Clear();
            }

            if (PotentialPartyMembers.Where(h => h.Name == choice).Count() != 0)
            {
                Hero h = PotentialPartyMembers.Find(h => h.Name == choice);
                party.Add(h);
                Party_Members.Remove(choice);
                Console.WriteLine($"{choice} har lagts till i party't!");
                Console.WriteLine("Klickan ENTER för att fortsätta vidare:");
                Console.ReadLine();
                Console.Clear();
            }
        }
        return party;
    }
}

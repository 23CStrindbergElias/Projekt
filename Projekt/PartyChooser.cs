
// Hela dett kodblock används för att välja ens party members
public class PartyChooser
{
    // Lista med de members man kan välja, de dras bort när man väljer en av dem från listan
    List<string> Party_Members = ["Warrior", "Mage", "Priest"];

    // Lista med instanser av partymembers, läggs till när de väljs, bra sätt att lagra
    List<Hero> PotentialPartyMembers = [new Warrior(), new Mage(), new Priest()];
    // Queue
    Queue<string> Intro = new();

    // Ett intro i queue samt ChooseParty med partymaxsize som parameter. Bestämmer hur många members ett marty kan ha
    public List<Hero> ChooseParty(int partyMaxSize)
    {
        // Simpelt intro, kan förbättras genom asci art
        Intro.Enqueue("Välkommen till boss-fighten");
        Intro.Enqueue("Klicka ENTER för att gå vidare:");
        Console.WriteLine(Intro.Dequeue());
        Console.WriteLine(Intro.Dequeue());
        Console.ReadLine();
        Console.Clear();
        // Skapar lista som heter party
        List<Hero> party = [];
        Console.WriteLine("Det är dags att välja ett party att spela som, du kan välja högst tre personer i ditt party.");
        string choice = "";

        // Så länge partycount är mindre än maxpartysize (3)
        while (party.Count < partyMaxSize)
        {
            // Skriver vilka du kan välja mellan
            Console.WriteLine($"Du kan nu välja mellan: {string.Join(", ", Party_Members)}");
            // Skriver ut vilka som är med i ditt party
            Console.WriteLine($"Ditt nuvarande party innehåller: {string.Join(", ", party)}");
            Console.WriteLine("Skriv ned vilken medlem du vill lägga till:");
            // Val för vem man vill välja
            choice = Console.ReadLine();

            // Om valet inte är med i Party_Members listan 
            // Bra och förhindrar crashout 
            if (!Party_Members.Contains(choice))
            {
                Console.WriteLine("Du får bara välja mellan de valen ovan!");
                Console.WriteLine("Klickan ENTER för att fortsätta vidare:");
                Console.ReadLine();
                Console.Clear();
            }

            // Lägger till valet i Party listan
            // Effektivt kodblock, kan kanske bli separat klass för att köra koden mindre
            if (PotentialPartyMembers.Where(h => h.Name == choice).Count() != 0)
            {
                Hero h = PotentialPartyMembers.Find(h => h.Name == choice);
                party.Add(h);
                
                Console.WriteLine(h.GetDesc());


                h.Party = party;
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

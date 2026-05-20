public class WrongMoveInput
{
    public  Hero ChoosePartyMember(List<Hero> party)
    {
        // Om man väljer fel kan man välja igen
        Console.WriteLine("Välj en av:");

        for (int i = 0; i < party.Count; i++)
        {
            Console.WriteLine($"{i + 1}) {party[i]}");
        }

        string s = Console.ReadLine();
        int Val = 0;

        while (!int.TryParse(s, out Val))
        {
            Console.WriteLine($"Du får bara skriva en siffra som motsvarar en i listan! (1-{party.Count})");
            for (int i = 0; i < party.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {party[i].Name}");
            }
            Console.WriteLine("Skriv in en siffra");
            s = Console.ReadLine();
        }

        return party[Val];
    }
}

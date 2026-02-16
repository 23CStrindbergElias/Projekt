public class Hero
{
    public string Name;
    public int HP;
    public int AP;
    public int MP;

    public string description;

    public List<string> Moves = ["Attack", "Defend", "Spells", "Do nothing"];
    public List<string> Spells = [];
    public List<string> Abilities = [];

    public void ListMoves()
    {
        for (int i = 0; i < Moves.Count; i++)
        {
            Console.WriteLine($"{i + 1}) {Moves[i]}");
        }
    }

    public void Do(string thing)
    {
        if (thing == "Attack")
        {
            
        }
        
        if (thing == "Spells")
        {
            
        }

        if (thing == "Defend")
        {
            
        }

        if (thing == "Do nothing")
        {
            
        }
    }


}

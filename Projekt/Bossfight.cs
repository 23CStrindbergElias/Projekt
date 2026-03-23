public class Bossfight
{
    bool BossFightOver = false;

    public void NewFight(List<Hero> Your_Party)
    {
        Console.WriteLine("Det är dags att slåss mot bossen");
        Console.WriteLine("Klicka på ENTER för att gå vidare:");
        Console.ReadLine();
        Console.Clear();
        Boss boss = new Boss();
        HeroTurn heroTurn = new HeroTurn();
        while (BossFightOver != true)
        {
            Console.WriteLine($"Bossen har {boss.HP} HP kvar.");
            for (int i = 0; i < Your_Party.Count(); i++)
            {
                Hero hero = Your_Party[i];
                heroTurn.HerosTurn(hero, boss);
                Console.WriteLine($"Bossen har nu {boss.HP} HP kvar.");
                Console.WriteLine("Klicka ENTER för att fortsätta.");
                Console.ReadLine();
            }
            
            int ChoiceHero = Random.Shared.Next(0, Your_Party.Count);

            boss.BossTurn(Your_Party[ChoiceHero]);
        }
    }
}

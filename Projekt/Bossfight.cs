public class Bossfight
{
    bool BossFightOver = false;

    // Hela bossfighten
    public void NewFight(List<Hero> Your_Party)
    {
        // Introduktion
        Console.WriteLine("Det är dags att slåss mot bossen");
        Console.WriteLine("Klicka på ENTER för att gå vidare:");
        Console.ReadLine();
        Console.Clear();
        // Ny instans av bossen
        Boss boss = new Boss();
        HeroTurn heroTurn = new HeroTurn();

        // Fortsätter tills BossFightOver är true
        while (BossFightOver != true)
        {
            Console.WriteLine($"Bossen har {boss.HP} HP kvar.");
            // Går genom alla party members och låter dem välja sitt move
            for (int i = 0; i < Your_Party.Count(); i++)
            {
                Hero hero = Your_Party[i];
                heroTurn.HerosTurn(hero, boss);
                Console.WriteLine($"Bossen har nu {boss.HP} HP kvar.");
                Console.WriteLine("Klicka ENTER för att fortsätta.");
                Console.ReadLine();
            }
            
            // Random nummer för en viss party member 
            int ChoiceHero = Random.Shared.Next(0, Your_Party.Count);

            // Nummret bestämmer vem som bossen attackerar
            boss.BossTurn(Your_Party[ChoiceHero]);

            // Ifall bossens HP är 0 eller under så är spelet slut
            if (boss.HP <= 0)
            {
                Console.Clear();
                BossFightOver = true;
                Console.WriteLine("Du dödade bossen!");
            }
        }
    }
}

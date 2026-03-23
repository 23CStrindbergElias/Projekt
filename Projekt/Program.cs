// Variabler & listor början

int Party_Size = 0;

string choice;

List<Hero> Your_Party = [];

// Variabler & listor slut


// Kod början

PartyChooser chooser = new();

Bossfight bossfight = new();

Bossfight fight = new();

Boss_turn boss_Turn = new();

Your_Party = chooser.ChooseParty(3);

fight.NewFight(Your_Party);




Console.ReadLine();

// Kod slut
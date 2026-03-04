// Variabler & listor början

int Party_Size = 0;

string choice;

List<Hero> Your_Party = [];

// Variabler & listor slut


// Kod början

PartyChooser chooser = new();

Bossfight bossfight = new();

Bossfight fight = new();

Your_Party = chooser.ChooseParty(3);
WrongMoveInput.ChoosePartyMember(Your_Party);

fight.NewFight(Your_Party);

Console.ReadLine();

// Kod slut
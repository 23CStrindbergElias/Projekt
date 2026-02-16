using Projekt;

public class Boss : Enemy
{
    public Boss()
    {
        Name = "Boss";
        HP = 700;
        AP = 20;
        MP = 50;

        Spells.Add("GiantFire");
        Spells.Add("IceStorm");

    }    
}
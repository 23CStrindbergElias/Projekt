using Projekt;

public class Ability
{
    public string Name;
    public int Damage;
    public virtual void Use(Hero hero, Enemy enemy)
    {

    }
    
    public virtual void Use(Hero hero, Hero target)
    {

    }
}
